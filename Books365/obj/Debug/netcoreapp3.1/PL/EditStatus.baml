   M S B A M L   `   `   `  ����C  ?Books365, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Books365.PLBooks365.PL  5   
       Books365.PL.EditStatus   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Books365.PL     5   
   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  AddBook��5
   	   $	��350��6   $	��350��6&    � Icon$ /PL/Images/bicon.ico��5   	    � AllowsTransparency$
 True��5   	   
������  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�6   .��5      � -   5         �Name$ GridOfWindow��5       � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��2* �6   6*   .+�5   
   ��  �� CornerRadius$ 10��6   $��2��6#   $��
0,10,0,-10q�64   ��5      �� 5      .��5      �  � Color$ #ba5370��6#   	 � Offset$		 0.0Q�63   � 5      $ #f4e2d8��6#   $		 1.0Q�63   5      5      �� 5   
   
 �� Orientation$
 
Horizontal=�6   $	��Top=�6.   $��Right=�6F   $��0��6b   .+�5      �� -   5        $��20��5   3   $��18��6>   $��0,10,0,0q�6J   ��5      �� 5       �� 6!   .�6&   -6)   60   5"      �� 5#      -   5        $��20��5#   /   $��18��6:   $��2,10,0,0q�6F   ��5$      �� 5%      �� 6!   .�6&   X6)   60   5'      5(      �� 5)   
   $��Center=�6   .+�5*      �� $��Images/book365logo.png��6   $��80��64   $��10q�6?   $��Center=�6K   �� 5+      $��Edit Status��5,      $��Light"�5-      $��	helvetica)�5.      $��22(�5/      
�������$��Center=�51      54      �� 55   
   $��1��6   .+�56      �� $
 
Horizontal=�6   $��0,20,0,0q�63   .+�57      �� -   5         ��Name$ BookISBN��57      $��	Helvetica)�6,   $��20(�58      $��Light"�59      $
��ISBN��5:      $��Center=�5;      
�������
������ $��0q�5>      $	��235��5?      $
��Left=�5@       J� Opacity$	 0.5Q�5A      $��25��5B      $��63,0,0,0q�5C      .  (MahApps.Metro.IconPacks.PackIconMaterial  5D         Kind$ 
Identifier=�6-   $��Center=�5E   )   $��Center=�5F   )   
�������5G   )   5J      �� 5K      $	��250��6   $��2��5L      
�������$	 0.5Q�5N      $��25,0,0,0q�6   63   �� 5O      $
 
Horizontal=�6   $��0,20,0,0q�63   .+�5P      �� -   5        $ 	PagesRead��5P      $��	Helvetica)�6-   $��20(�5Q      $��Light"�5R      $��
Pages Read��5S      $��Center=�5T      
�������
������ $��0q�5W      $	��235��5X      $
��Left=�5Y      $	 0.5Q�5Z      $��25��5[      $��63,0,0,0q�5\        5]      $
 Book=�6-   $��Center=�5^   )   $��Center=�5_   )   
�������5`   )   5c      �� 5d      $	��250��6   $��2��5e      
�������$	 0.5Q�5g      $��25,0,0,0q�6   63   �� 5h      $
 
Horizontal=�6   $��0,20,0,0q�63   .+�5i      �� -   5        $ 
RatingText��5i      $��	Helvetica)�6.   $��20(�5j      $��Light"�5k      $��Rating��5l      $��Center=�5m      
�������
������ $��0q�5p      $	��100��5q      $
��Left=�5r      $	 0.5Q�5s      $��25��5t      $��63,0,0,0q�5u      �� 5v      -   5         ��Name$ FinishedBook��5v      $��40,0,0,0q�61    d� 	IsChecked$ FalseY�6C   $��20��6U   $��Finihed Book?��6a   5z      �� 5{      $	��250��6   $��2��5|      
�������$	 0.5Q�5~      $��25,0,0,0q�6   63   5�      �� 5�   
   -   5         ��Name$ ButtonCancel��5�      $��
35,10,0,25q�6'   $��1��6;   $	��100��6H   $��40��6T   $��Cancel��6`   $��Bottom=�6r   $
��Left=�6�   6�   �� 5�   
   -	   5        $ Button_change��5�      $��
0,10,35,25q�6(   $��1��6<   $	��100��6I   $��40��6U   $��Edit Status��6a   $��Bottom=�6x   $��Right=�6�   6�   5�      5�      