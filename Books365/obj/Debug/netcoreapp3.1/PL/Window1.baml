   M S B A M L   `   `   `  ����C  ?Books365, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Books365.PLBooks365.PL  5   	       Books365.PL.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Books365.PL     5   	   Hgrid9http://schemas.microsoft.com/netfx/2009/xaml/presentation    5   	     � AllowsTransparency$
  True��5	   	   
������  � WindowStyle$
 None=�5
   	    � Title$ 	ShowBooks��5   	   $	��450��6   $	��900��6(    � Icon$ /PL/Images/bicon.ico��5   	   .��5      � -   5         �Name$ GridOfWindow��5       � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��6* �6   6*   .+�5   
   ��  �� CornerRadius$ 10��6   $��2��6#   $��0,10,21,-10q�64   ��5      �� 5      .��5      �  � Color$ #ba5370��6#    � Offset$	 0.0Q�63   � 5      $ #f4e2d8��6#   $	 1.0Q�63   5      5      �� 5   
   	 �� Orientation$	 
Horizontal=�6   $	��Top=�6.   $��Right=�6F   $��0��6b   $��0,3,22,0q�6o   .+�5       �� -   5        $��20��5    3   $��18��6>   $��0,10,0,0q�6J   ��5!      �� 5"      �� 6!   .�6&   -6)   60   5$      �� 5%      -   5        $��20��5%   /   $��18��6:   $��0,10,0,0q�6F   ��5&      �� 5'      �� 6!   .�6&   X6)   60   5)      5*      �� 5,   
   $��/PL/Images/Logo.png��6   $��85��6-   $��42,36,0,364q�69   $
��Left=�6N   $��2��6i   �� 5-   
   -   5        
 ��Name$
 search_textbox��5-      $
��Left=�6*   $��	42,56,0,0q�6E    �� TextWrapping$
 Wrap=�6X   $��Search��6l   $	��Top=�6z   $	��109��6�   $��24��6�   $��1��6�   �� 5.   
   $��0��6   $��
0,0,-695,0q�6"   $��Center=�66   $��Bottom=�6T   $	 Vertical=�6o   .+�5/      �� -   5         ��Name$ user_name_text_block��5/   P   $��Center=�6   $��Center=�63   $��20(�6n   $��UserName��6  
�������6  �� 50      $��95��6   $��2��51      
������� J� Opacity$	 0.5Q�53      $	��Top=�6   54      �� 56   
   -   5         ��Name$ add_book_button��56      $��Add book��6*    J� RenderTransformOrigin$ 0.496,0.548&�6=   $��300,0,504,305q�6a   $��1��6x   $��32��6�   $��Bottom=�6�   �� 57   
   -   5        $ change_status��57      $��Change Status��6(   $ 0.496,0.548&�6@   $��419,0,385,305q�6d   $��1��6{   $��32��6�   $��Bottom=�6�   �� 58   
   -   5        $ simple_search_button��58      $��Search��6/   $
��Left=�6@   $��
156,52,0,0q�6[   $	��Top=�6o   $��33��6�   $��51��6�   $��1��6�   $ 0.518,0.567&�6�   �� 59   
   -	   5        $ Reset_button��59      $��Reset��6'   $
��Left=�67   $��
215,52,0,0q�6R   $	��Top=�6f   $��33��6~   $��51��6�   $��1��6�   $ 0.518,0.567&�6�   �� 5;   
   -
   5        $ log_out_button��5;      $��Log out��6)   $
��Left=�6;   $��	750,5,0,0q�6V   $	��Top=�6i   $��34��6�   $��94��6�   $��1��6�   �� 5<   
   -   5        $ notifications_button��5<      $��SetNotifications��62   $��1��6M   $��736,327,42,26q�6}   &   System.Windows.Controls.DataGrid  5>   
   -   5          Name$ 	BooksGrid��5>      $��10,90,169,0q�6&      AutoGenerateColumns$ False��6;   $	��270��6W   $��1��6d   $	��Top=�6q      Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$
 ISBN��6<      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6J     5A      $ 	Book Name��6?   $	 120 6R    6%   �� *Title+6R     5B      $ Author��6@   $	 100 6P    6%   �� *Author+6P     5C      $
 Year��6>   $ 80 6L    6%   �� *Year+6L     5D      $ Rating��6@   $ 80 6P    6%   �� *Rating+6P     5E      $ Pages��6?   $ 80 6N    6%   �� *Pages+6N     5F      $ Status��6G   $ 80 6W    6%   �� *ReadingStatus+6W   5H      5I      5J      