   M S B A M L   `   `   `  ����C  ?Books365, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Books365.PLBooks365.PL  5   
        Books365.PL.AdvancedSearch   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Books365.PL     5   
   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  AdvancedSearch��5
   	   $	��350��6    $	��350��6-    � Icon$ /PL/Images/bicon.ico��5   	    � AllowsTransparency$
 True��5   
   
������  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�6   .��5      � -   5         �Name$ GridOfWindow��5       � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��2* �6   6*   .+�5   
   ��  �� CornerRadius$ 10��6   $��2��6#   $��
0,10,0,-10q�64   ��5      �� 5      .��5      �  � Color$ #ba5370��6#   	 � Offset$		 0.0Q�63   � 5      $ #f4e2d8��6#   $		 1.0Q�63   5      5      �� 5   
   
 �� Orientation$
 
Horizontal=�6   $	��Top=�6.   $��Right=�6F   $��0��6b   .+�5      �� -   5        $��20��5   3   $��18��6>   $��0,10,0,0q�6J   ��5      �� 5      �� 6!   .�6&   -6)   60   5!      �� 5"      -   5        $��20��5"   /   $��18��6:   $��2,10,0,0q�6F   ��5#      �� 5$      �� 6!   .�6&   X6)   60   5&      5'      �� 5(   
   $��Center=�6   .+�5)      �� $��Images/book365logo.png��6   $��80��64   $��10q�6?   $��Center=�6K   �� 5*      $��	Books 365��5+      $��Light"�5,      $��	helvetica)�5-      $��22(�5.      
�������$��Center=�50      53      �� 54   
   $��1��6   .+�55      �� $
 
Horizontal=�6   $��0,20,0,0q�63   .+�56      �� -   5         ��Name$ 	TitleText��56      $��	Helvetica)�6-   $��20(�57      $��Light"�58      $��Title��59      $��Center=�5:      
�������
������ $��0q�5=      $	��235��5>      $
��Left=�5?       J� Opacity$	 0.5Q�5@      $��25��5A      $��63,0,0,0q�5B      .  (MahApps.Metro.IconPacks.PackIconMaterial  5C         Kind$ BookEdit=�6-   $��Center=�5D   )   $��Center=�5E   )   
�������5F   )   5I      �� 5J      $	��250��6   $��2��5K      
�������$	 0.5Q�5M      $��25,0,0,0q�6   63   �� 5N      $
 
Horizontal=�6   $��0,20,0,0q�63   .+�5O      �� -   5        $ YearText��5O      $��	Helvetica)�6,   $��20(�5P      $��Light"�5Q      $
��Year��5R      $��Center=�5S      
�������
������ $��0q�5V      $	��235��5W      $
��Left=�5X      $	 0.5Q�5Y      $��25��5Z      $��63,0,0,0q�5[        5\      $ Calendar=�6-   $��Center=�5]   )   $��Center=�5^   )   
�������5_   )   5b      �� 5c      $	��250��6   $��2��5d      
�������$	 0.5Q�5f      $��25,0,0,0q�6   63   �� 5g      $
 
Horizontal=�6   $��0,20,0,0q�63   .+�5h      �� -   5        $ 
AuthorText��5h      $��	Helvetica)�6.   $��20(�5i      $��Light"�5j      $��Author��5k      $��Center=�5l      
�������
������ $��0q�5o      $	��235��5p      $
��Left=�5q      $	 0.5Q�5r      $��25��5s      $��63,0,0,0q�5t        5u      $ HumanGreeting=�6-   $��Center=�5v   )   $��Center=�5w   )   
�������5x   )   5{      �� 5|      $	��250��6   $��2��5}      
�������$	 0.5Q�5      $��25,0,0,0q�6   63   5�      �� 5�   
   -   5         ��Name$ ButtonCancel��5�      $��
55,10,0,25q�6'   $��1��6;   $	��100��6H   $��40��6T   $��Cancel��6`   $��Bottom=�6r   $
��Left=�6�   6�   �� 5�   
   -   5        $ ButtonSearch��5�      $��
0,10,35,25q�6'   $��1��6;   $	��100��6H   $��40��6T   $��Search��6`   $��Bottom=�6r   $��Right=�6�   6�   5�      5�      