   M S B A M L   `   `   `  ����C  ?Books365, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Books365.PLBooks365.PL  5   	       Books365.PL.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Books365.PL     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   61     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterOwner=�6K    � AllowsTransparency$
 True��6o    � WindowStyle$
 None=�6�    � Icon$ /PL/Images/bicon.ico��5	   	    � 	Resources 5
         Storyboard1 �� 
TargetName �� TargetProperty8  2System.Windows.Media.Animation.EasingPointKeyFrame	 $� KeyTime
 $� Value R� KeyTime  System.Windows.Visibility   Visible R� Value   Hidden9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value  Storyboard_Copy1��%�  &	        &	 �	    �� 5   
   .��5      *� $
 path��6+   $C =(Path.Data).(PathGeometry.Figures)[0].(PathFigure.StartPoint)�6H   .'�5        $	 00:00:00��6&   $
 146,504&�69     5      $	 00:00:00.1000000��6&   $
 88,502&�6A   5      T� 5      $ LogIn��6,   $ (UIElement.Visibility)�6J   ..�5      i� $ 00:00:00��6)   # Z 6<   i� 5      $ 00:00:00.1000000��6)   # Z 6D   i� 5      $ 00:00:00.6000000��6)   # Z 6D   5      U� 5      $
 path��6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6I   .\�5        $ 00:00:00.1000000��6'   $ 0Q�6B     5      $ 00:00:00.2000000��6'   $
 -150Q�6B     5      $ 00:00:00.3000000��6'   $
 -288Q�6B     5      $ 00:00:00.4000000��6'   $
 -380Q�6B   5      U� 5      $
 path��6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6I   .\�5        $ 00:00:00.1000000��6'   $ 0Q�6B     5      $ 00:00:00.2000000��6'   $ 0Q�6B     5      $ 00:00:00.3000000��6'   $ 0Q�6B     5      $ 00:00:00.4000000��6'   $ 0Q�6B   5       *� 5!      $
 path��6+   $X R(Path.Data).(PathGeometry.Figures)[0].(PathFigure.Segments)[2].(LineSegment.Point)�6H   .'�5"        $	 00:00:00.4000000��6&   $'
 !536.506419314328,501.497004662654&�6A     5#      $	 00:00:00.5000000��6&   $
 446,502&�6A   5$      *� 5%      $
 path��6+   $X R(Path.Data).(PathGeometry.Figures)[0].(PathFigure.Segments)[1].(LineSegment.Point)�6H   .'�5&        $	 00:00:00.4000000��6&   $(
 "534.009123162192,0.500000004244478&�6A     5'      $	 00:00:00.5000000��6&   $
 499,0.999999999999994&�6A     5(      $	 00:00:00.6000000��6&   $
 486,1.99999999999999&�6A   5)      T� 5*      $ SignUp��6,   $ (UIElement.Visibility)�6K   ..�5+      i� $ 00:00:00��6)   # Z 6<   i� 5,      $ 00:00:00.6000000��6)   # Z 6D   5-      T� 5.      $ Exit_Min��6,   $ (UIElement.Visibility)�6M   ..�5/      i� $ 00:00:00��6)   # Z 6<   i� 50      $ 00:00:00.6000000��6)   # Z 6D   51      �� 52      $ button��6+   $2 ,(Control.Background).(SolidColorBrush.Color)�6J   .g�53        $ 00:00:00.6000000��6&   $ 	#FFBA5370��6A   54      �� 55      $ button1��6+   $2 ,(Control.Background).(SolidColorBrush.Color)�6K   .g�56        $ 00:00:00.6000000��6&   $ 	#FFBA5370��6A   57      58      �� 59   
   .��5:      *� $
 path��6+   $C =(Path.Data).(PathGeometry.Figures)[0].(PathFigure.StartPoint)�6H   .'�5;      �� $	 00:00:00.5000000��6&   $
 88,502&�6A   �� 5<      $	 00:00:00.6000000��6&   $
 146,504&�6A   5=      T� 5>      $ LogIn��6,   $ (UIElement.Visibility)�6J   ..�5?      i� $ 00:00:00��6)   # Z 6<   i� 5@      $ 00:00:00.5000000��6)   # Z 6D   i� 5A      $ 00:00:00.6000000��6)   # Z 6D   5B      U� 5C      $
 path��6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6I   .\�5D      �� $ 00:00:00.2000000��6'   $
 -380Q�6B   �� 5E      $ 00:00:00.3000000��6'   $
 -288Q�6B   �� 5F      $ 00:00:00.4000000��6'   $
 -150Q�6B   �� 5G      $ 00:00:00.5000000��6'   $ 0Q�6B   �� 5H      $ 00:00:00.6000000��6'   $ 0Q�6B   5I      U� 5J      $
 path��6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6I   .\�5K      �� $ 00:00:00.2000000��6'   $ 0Q�6B   �� 5L      $ 00:00:00.3000000��6'   $ 0Q�6B   �� 5M      $ 00:00:00.4000000��6'   $ 0Q�6B   �� 5N      $ 00:00:00.5000000��6'   $ 0Q�6B   �� 5O      $ 00:00:00.6000000��6'   $ 0Q�6B   5P      *� 5Q      $
 path��6+   $X R(Path.Data).(PathGeometry.Figures)[0].(PathFigure.Segments)[2].(LineSegment.Point)�6H   .'�5R      �� $	 00:00:00.1000000��6&   $
 446,502&�6A   �� 5S      $	 00:00:00.2000000��6&   $'
 !536.506419314328,501.497004662654&�6A   �� 5T      $	 00:00:00.6000000��6&   $'
 !536.506419314328,501.497004662654&�6A   5U      *� 5V      $
 path��6+   $X R(Path.Data).(PathGeometry.Figures)[0].(PathFigure.Segments)[1].(LineSegment.Point)�6H   .'�5W      �� $	 00:00:00.1000000��6&   $
 499,0.999999999999994&�6A   �� 5X      $	 00:00:00.2000000��6&   $(
 "534.009123162192,0.500000004244478&�6A   �� 5Y      $	 00:00:00.6000000��6&   $(
 "534.009123162192,0.500000004244478&�6A   5Z      T� 5[      $ SignUp��6,   $ (UIElement.Visibility)�6K   ..�5\      i� $ 00:00:00��6)   # Z 6<   i� 5]      $ 00:00:00.1000000��6)   # Z 6D   i� 5^      $ 00:00:00.6000000��6)   # Z 6D   5_      T� 5`      $ Exit_Min��6,   $ (UIElement.Visibility)�6M   ..�5a      i� $ 00:00:00��6)   # Z 6<   i� 5b      $ 00:00:00.6000000��6)   # Z 6D   5c      5d      5e      .��5h      � -   5         �Name$ GridOfWindow��5h      .+�5i   
   F� -   5         F�Name$
 path��5i      ���#ba5370$
��Left=�6,   $	��504��6G   $��	292,0,0,0q�6T   
���   �$��Center=�6v   $	��538��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��5j      B� 5k      .��5l      E�  E� 
StartPoint$ 146,504&�6!   .��5m      ��  �� Point$' !83.5000000130483,2.00299553624249&�6&   �� 5n      $( "534.009123162192,0.500000004244478&�6&   �� 5o      $' !536.506419314328,501.497004662654&�6&   5p      5q      z�5s      V� 5t      .~�5u      �� �� 5v      �� 5w      T� 5x      5y      5{      �� 5|   
   -   5         ��Name$ Exit_Min��5|       �� Orientation$ 
Horizontal=�6'   $	��Top=�6@   $��Right=�6X   .+�5}      �� -   5         ��Name$ button1��5}      $��20��6D   $��18��6O   $��0,0,0,0q�6[   ���	#00000000��5~      �� 5      �� 6!   .�6&   -6)   60   5�      �� 5�      -   5        $ button��5�      $��20��6?   $��18��6J   $��2,00,0,0q�6V   ���	#00000000��5�      �� 5�      �� 6!   .�6&   X6)   60   5�      5�      � 5�   
   -   5        $ SignUp��5�      $
��Left=�6   $	��459��6:   $	��Top=�6G   $	��786��6_   $y�Hidden=�6k   .+�5�      �� $
��Left=�6   $��21��63   $��Books365��6?   $
��Wrap=�6O   $	��Top=�6c   $��86��6{   $��18(�6�   $
��Bold"�6�   $��	10,10,0,0q�6�   �� 5�      -   5        $��SIGN UP��5�   .   $
��Left=�6@   $��40��6[   $��461,409,0,0q�6g   $	��Top=�6|   $	��282��6�   $
��Bold"�6�   ���#ba53706�   G� 5�      -   5         G�Name$ Password_Register��5�   P    G� Password$ Password��6   $��Center=�6.   $
��Left=�6�   $��35��6�   $��463,274,0,0q�6�   $	��Top=�6�   $	��282��6�   �� 5�      -	   5         ��Name$ FirstNameTextBox��5�   K   $
��Left=�6e   $��35��6�   $��463,151,0,0q�6�   $��Your first name��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��133��6�   $��Center=�6�   �� 5�      $
��Left=�6   $��17��63   $��463,195,0,0q�6?   $��Email��6T   $
��Wrap=�6a   $	��Top=�6u   $	��282��6�   $
��Bold"�6�    �� TextAlignment$
 Left=�6�   �� 5�      $
��Left=�6   $��17��63   $��463,129,0,0q�6?   $��
First Name��6T   $
��Wrap=�6f   $	��Top=�6z   $��94��6�   $
��Bold"�6�   $
 Left=�6�   �� 5�      $
��Left=�6   $��39��63   $��
463,85,0,0q�6?   $H��BLet`s you all set up so you can start working with our amazing app��6S   $
��Wrap=�6�   $	��Top=�6�   $	��282��6�   $��Normal"�6�   $ Center=�6�   �� 5�      $
��Left=�6   $��24��63   $��
421,49,0,0q�6?   $��Sign Up for an account��6S   $
��Wrap=�6q   $	��Top=�6�   $	��365��6�   $��18(�6�   $
��Bold"�6�   $ Center=�6�   �� 5�      $
��Left=�6   $��17��63   $��613,129,0,0q�6?   $��	Last Name��6T   $
��Wrap=�6e   $	��Top=�6y   $��93��6�   $
��Bold"�6�   $
 Left=�6�   �� 5�      -
   5        $ LastNameTextBox��5�   J   $
��Left=�6c   $��35��6~   $��614,151,0,0q�6�   $��Your last name��6�   $
 Wrap=�6�   $	��Top=�6�   $	��131��6�   $��Center=�6�   �� 5�      $
��Left=�6   $��17��63   $��463,257,0,0q�6?   $��Password��6T   $
��Wrap=�6d   $	��Top=�6x   $	��281��6�   $
��Bold"�6�   $
 Left=�6�   �� 5�      -   5        $ SecretPinTextBox��5�   m   $��Center=�6K   $
��Left=�6�   $��35��6�   $��462,341,0,0q�6�   $��Enter your secret pin��6�   $
 Wrap=�6�   $	��Top=�6�   $	��281��6  �� 5�      $
��Left=�6   $��17��63   $��463,319,0,0q�6?   $��
Secret Pin��6T   $
��Wrap=�6f   $	��Top=�6z   $	��281��6�   $
��Bold"�6�   $
 Left=�6�   �� 5�      -   5        $ Email_Register��5�   k   $��Center=�6   $
��Left=�6�   $��35��6�   $��	463,0,0,0q�6�   $��Enter your email��6�   $
 Wrap=�6�   $��Center=�6�   $	��281��6  �� 5�      $
��Left=�6   $��39��63   $��
55,176,0,0q�6?   $F��@Log in to your account so you can work with books365 application��6S   $
��Wrap=�6�   $	��Top=�6�   $	��282��6�   $��Normal"�6�   $ Center=�6�   
�������6�   �� 5�      $
��Left=�6   $��24��63   $��
14,147,0,0q�6?   $��Already signed up?��6S   $
��Wrap=�6m   $	��Top=�6�   $	��365��6�   $��14(�6�   $
��Bold"�6�   $ Center=�6�   
�������6�   �� 5�      $��LOG IN��6   $
��Left=�6&   $��31��6A   $��136,227,0,0q�6M   $	��Top=�6b   $	��121��6z   $
��Bold"�6�     � Triggers  5�      :� 5�      ! :� RoutedEvent$! Button.Click��6#   .[�5�      �� #��[ 6*   5�      5�      5�      � 5�   
   -   5        $ LogIn��5�      $
��Left=�6   $	��398��69   $��	10,10,0,0q�6F   $	��Top=�6Y   $	��768��6q   " � ColumnDefinitions" 5�      �� 5�      $��3* �6#   �� 5�      $	��29* �6#   .+�5�      �� $��SIGN UP��6   $
��Left=�6'   $��33��6B   $	��Top=�6N   $	��141��6f   $
��Bold"�6r   $��442,269,0,0q�6�   $��1��6�     5�      :� 5�      $! Button.Click��6#   .[�5�      �� #��[  6*   5�      5�      �� 5�      $
��Left=�6   $��39��63   $��372,225,0,0q�6?   $H��BLet`s you all set up so you can start working with our amazing app��6T   $
��Wrap=�6�   $	��Top=�6�   $	��282��6�   $��Normal"�6�   $ Center=�6�   
�������$��1��6  �� 5�      $
��Left=�6   $��24��63   $��331,196,0,0q�6?   $ ��Don`t have an account yet?��6T   $
��Wrap=�6v   $	��Top=�6�   $	��365��6�   $��14(�6�   $
��Bold"�6�   $ Center=�6�   
�������$��1��6�   �� 5�      -   5        $��LOG IN��5�   0   $
��Left=�6A   $��33��6\   $��
43,353,0,0q�6h   $	��Top=�6|   $	��260��6�   ���#ba5370$
��Bold"�6�   $��2��6�   �� 5�      -   5        # ��Name$# LabelForgot��5�   |   $
��Left=�6�   $��25��6�   $��101,328,0,0q�6�   $��Forgot password ?��6�   $
��Wrap=�6�   $	��Top=�6�   $	��130��6  $��10(�6  $ Right=�6,  ���#ba5370$��1��6W  G� 5�      -   5        $ PasswordTextBox��5�   b   $ Password��6   $��Center=�6{   $
��Left=�6�   $��35��6�   $��
43,277,0,0q�6�   $	��Top=�6�   $	��260��6�   $��2��6�   �� 5�      -   5        $ EmailTextBox��5�   <   $
��Left=�6R   $��35��6m   $��
43,210,0,0q�6y   $��Email��6�   $
 Wrap=�6�   $	��Top=�6�   $	��260��6�   $��Center=�6�   $��2��6�   �� 5�      $
��Left=�6   $��17��63   $��
43,255,0,0q�6?   $��Password��6S   $
��Wrap=�6c   $	��Top=�6w   $	��281��6�   $
��Bold"�6�   $
 Left=�6�   $��2��6�   �� 5�      $
��Left=�6   $��17��63   $��
43,188,0,0q�6?   $��Email��6S   $
��Wrap=�6`   $	��Top=�6t   $	��281��6�   $
��Bold"�6�   $
 Left=�6�   $��2��6�   �� 5�      $
��Left=�6   $��39��63   $��
43,144,0,0q�6?   $F��@Log in to your account so you can work with books365 application��6S   $
��Wrap=�6�   $	��Top=�6�   $	��282��6�   $��Normal"�6�   $ Center=�6�   $��2��6�   �� 5�      $
��Left=�6   $��24��63   $��	0,106,0,0q�6?   $��Log in to your Account��6R   $
��Wrap=�6p   $	��Top=�6�   $	��365��6�   $��18(�6�   $
��Bold"�6�   $ Center=�6�   $��2��6�   �� 5�      $
��Left=�6   $��21��63   $��Books365��6?   $
��Wrap=�6O   $	��Top=�6c   $��86��6{   $��18(�6�   $
��Bold"�6�   $��2��6�   5�      5�      5�      