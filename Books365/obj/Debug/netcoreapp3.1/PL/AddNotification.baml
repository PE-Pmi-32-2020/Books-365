   M S B A M L   `   `   `  ����C  ?Books365, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Books365.PLBooks365.PL  5   	   !    Books365.PL.AddNotification   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Books365.PL     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Title$ AddNotification��5   	   $	��600��6!   $	��500��6.    � Icon$ /PL/Images/bicon.ico��5   	   .��5      � -   5         �Name$ GridOfWindow��5       � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   ��  �� CornerRadius$ 10��6   $��2��6#   $��0q�64   ��5      �� 5      .��5      �  � Color$ #ba5370��6#   	 � Offset$		 0.0Q�63   � 5      $ #f4e2d8��6#   $		 1.0Q�63   5      5      �� 5   
   
 �� Orientation$
 
Horizontal=�6   $	��Top=�6.   $��Right=�6F   $��0��6b   .+�5      �� -   5        $��20��5   3   $��18��6>   $��2,5,0,0q�6J   ��5      �� 5      �� 6!   .�6&   -6)   60   5!      �� 5"      -   5        $��20��5"   /   $��18��6:   $��2,5,2,0q�6F   ��5#      �� 5$      �� 6!   .�6&   X6)   60   5&      5'      �� 5(   
   $��Center=�6   .+�5)      �� $��/PL/Images/Logo.png��6   $��80��61   $��10q�6<   $��Center=�6H   �� 5*      $��	Books 365��5+      $��Light"�5,      $��	helvetica)�5-      $��22(�5.      
�������$��Center=�50      53      �� 56   
   $��1��6   .+�57      �� $
 
Horizontal=�6   .+�58      �� $��40 10 80 10q�6   $��	Helvetica)�6-   $��20(�6D   .��6R   Time6X   (  "System.Windows.Controls.DatePicker  59      -   5        $��Picker��59      $	��329��6+   $��30��67    � 	Resources 5:      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value ��Name �� Path �� RelativeSource �� AncestorType �� StringFormat��%�  '        �� 5;      "  6    .�5<      ��  � �� 5=   "   �� 5>   &   .R�5?   *   �� $
 time��62   $��25��6@   ��6L   �� $ SelectedDate� ��  
DatePicker$ {0:dd/MM/yyyy hh:mm:ss}��.��6�    5@   .   ���� 5A   2   '��       " ��68   .�5B   6   ��  �@��CornerRadius$ 10��6U   5C   3   5D   /   .��6A   5E   +   5F   '   5H      5I      5J      5K      5L      �� 5N      $��30 10 30 10q�6   $��2��5O      
������� J� Opacity$	 0.5Q�5Q      6%   �� 5S      $
 
Horizontal=�6   .+�5T      �� $��40 10 50 10q�6   $��	Helvetica)�6-   $��20(�6D   $
��Left=�6R   .��6m   	Message6v   �� 5U      -   5        $ Message��5U      $��	Helvetica)�6+   $��20(�6B   $	��300��6P   $��25��6\   $
��Left=�5V      
���   �.��5W   -    5X      ��%_   '��       �� 5Y      " ��6    .�5Z      ��  �@��CornerRadius$ 10��6=   5[      5\      .��6)   5]      5^      �� 5`      $��30 10 30 10q�6   $��2��5a      
�������$	 0.5Q�5c      6%   �� 5e      $��1��6   $
 
Horizontal=�6&   $��0,50,0,0q�6?   $��Right=�6Q   .+�5f      �� -   5         ��Name$ Ok��5f      $	��100��6%   $��40��61   $��Ok��6=   6J   �� 5g      -   5        $ Cancel��5g      $	��100��6)   $��40��65   $��Cancel��6A   $��	20,0,20,0q�6R   6e   5h      5i      5j      5k      