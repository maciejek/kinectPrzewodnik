   M S B A M L   `   `   `  ���� E  APrzewodnik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Przewodnik.ControlsPrzewodnik.Controls  ;"clr-namespace:Przewodnik.UtilitiesPrzewodnik.Utilities  _ [Microsoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35eHclr-namespace:Microsoft.Kinect.Toolkit;assembly=Microsoft.Kinect.ToolkitMicrosoft.Kinect.Toolkit     Przewodnik.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     h dMicrosoft.Kinect.Toolkit.Controls, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e352k(http://schemas.microsoft.com/kinect/2013   +c!clr-namespace:Przewodnik.Controls   ,u"clr-namespace:Przewodnik.Utilities   StkHclr-namespace:Microsoft.Kinect.Toolkit;assembly=Microsoft.Kinect.Toolkit     � Title$  Przewodnik turystyczny�� � WindowState$ 	Maximized=�$
��1920��$
��1080�� � WindowStyle$
 None=� � Cursor$
 None�� � 	Resources    EngagedUserColor �� A �� R �� G �� B  TrackedUserColor  EngagedUserMessageBrush	 �� Color  TrackedUserMessageBrush % !PostEngagementBackgroundUserColor % !PostEngagementBackgroundUserBrush  HandoffTextTemplate  HandoffButtonContent��%&  &	        &	 -     &	 Z     &	 o     &	 �     &	 �     7  &	 �     &	    �� $	 #80��$	 #51��$	 #1C��$	 #74���� $	 #80��$	 #00��$	 #BC��$	 #F2���� $	 	#FF511C74���� $	 	#FF00BCF2���� $	 #80��$	 #BC��$	 #BE��$	 #C0���� 8	   �� .R��� $
��Wrap=�$��30(�
�������$��25 10q�$��Center=�$
��Left=����� � 
������ $��Center=�$��Center=�.+��� .+��� $��Center=�
�������$��36(�$��0q�$��
Press Here���� $��Center=�
�������$��24(�$��0 5 0 0q�$��To take control��.��� -   $��
TopTopGrid��.+�4  .Microsoft.Kinect.Toolkit.Controls.KinectRegion  -   $��kinectRegion��
   KinectSensor
 �� *KinectSensorChooser.Kinect+   IsCursorVisible �� *IsUserActive+)   "QueryPrimaryUserTrackingIdCallback �� *QueryPrimaryUserCallback+.��� .+��� $	��128��$��96��$	��Top=�#��[ $��1q�y��� *IsUserEngaged+ * &InvertibleBooleanToVisibilityConverter �� 	Converter# [ ._�8  2Microsoft.Kinect.Toolkit.Controls.KinectUserViewer     DefaultUserColor# [    UserColoringMode$ Manual=�   ImageBackground
 ����    
UserColors �� *PostEngagementUserColors+�  � RowDefinitions �� -    �Name$ TopRow��$��0.18* ��� -   $ 
ContentRow��$��0.82* �.+��  
	 TopRow#��[	 $��0��.+�:  4Microsoft.Kinect.Toolkit.Controls.KinectCircleButton  -   $��
BackButton��$��0��$
��Left=�$
��Auto��$
��Auto��
������ .���� $,��&/Content/Design/Images/back-button.png���� $��1��$��Right=�$%��/Content/Design/Images/logo.png��� -   $��PageContentGrid��$��1�� 
 BackgroundGradientBrush#��[
 4  .Microsoft.Kinect.Toolkit.KinectSensorChooserUI  $��Center=�   IsListening .  $��0 0 0 5q�   KinectSensorChooser �� *KinectSensorChooser+