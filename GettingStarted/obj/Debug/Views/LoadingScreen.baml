   M S B A M L   `   `   `  ����E  APrzewodnik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Przewodnik.ConvertersPrzewodnik.Converters  5      $    Przewodnik.Views.LoadingScreen   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      h dMicrosoft.Kinect.Toolkit.Controls, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [Microsoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e352k(http://schemas.microsoft.com/kinect/2013   5      6
converters#clr-namespace:Przewodnik.Converters   5      c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5      -   5        $��TwitterGrid��5         BackgroundGradientBrush#��[  5      .+�5	      �� $��Center=�6   .+�5
   
   �� $��center=�6   $.��(/Content/Design/Images/logo_vertical.png��6-     LoaderLogoWidth#���  6_   � 5   
   $��Center=�6     LoaderWidth#���  6,     LoaderHeight#���  6R     LoaderTopMargin#���  6z   .+�5      �� -   5        $
��mask��5      
�������  �� CornerRadius$  9��64   � 5      #���  6   #���  69    J� OpacityMask 5      !� 5       !� Visual 6"   ��  �� ElementName$
 mask��.+�5      �� #���  6   #���  6B     	GrayColor#��[ 6j   �� 5      -   5        $��ProgressBar��5      $��0��6/   #���  69     	BlueColor#��[ 6a   $
��Left=�6�   5      5      � 5   
   #���  6   .+�5      �� -   5         ��Name$ StatusLoader��5      #��[ 6.    
 Size32#���  6V   $��Light"�6z    
 Size60 �� 
LineHeight# �  6�    �� LineStackingStrategy$ BlockLineHeight=�6�   $
��Left=�6�   $��Center=�6�   �� 6  $� ��6  6   �� 5      -   5        $ PercentLoader��5      #��[ 6/   #���  6W   $��Light"�6{   # �  6�   $ BlockLineHeight=�6�   $��Right=�6�   $��Center=�6�   �� 6  $�0%��6  6$  5      5      5      