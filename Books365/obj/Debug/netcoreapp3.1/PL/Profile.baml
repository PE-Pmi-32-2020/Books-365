   M S B A M L   `   `   `  ����C  ?Books365, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Books365.PLBooks365.PL  5   	       Books365.PL.Profile   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NOxyPlot.Wpf, Version=2.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   %localclr-namespace:Books365.PL  5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   61     � Title$  Profile��5	   	   $	��500��6   $	��550��6&    � AllowsTransparency$
 True��5
   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � Icon$ /PL/Images/bicon.ico��5   	    � DataContext 5         Books365.PL.MainViewModel  5   
   .��5      � -   5         �Name$ GridOfWindow��5      .+�5   
   ��  �� CornerRadius$ 10��6   $��2��6#   $��
0,10,0,-10q�64    J� RenderTransformOrigin$ 0.496,0.556&�6H   ��5      �� 5      .��5      � 	 � Color$	 #ba5370��6#   
 � Offset$	
 0.0Q�63   � 5      $	 #f4e2d8��6#   $	
 1.0Q�63   5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $��Right=�6F   .+�5      �� -   5        $��20��5   3   $��18��6>   $��0,10,0,0q�6J   ��5      �� 5      �� 6!   .�6&   -6)   60   5      �� 5       -   5        $��20��5    /   $��18��6:   $��2,10,0,0q�6F   ��5!      �� 5"      �� 6!   .�6&   X6)   60   5$      5%      �� 5&   
   $��Images/book365logo.png��6   $	��120��60   $��	0,0,0,100q�6<   $��Center=�6O   $	��Top=�6l   �� 5'   
   $	��Top=�6   $��	0,100,0,0q�6-   .+�5(      �� -   5         ��Name$ Username��5(      $��SomeUser��6*   $��40(�6:   $��Light"�6H   $��	helvetica)�6[   
�����f�$��Center=�6�   6�   5)      �� 5+   
   $	��Top=�6   $
��Left=�6-   $��
10,170,0,0q�6H   .+�5,      �� -   5        $ Total��5,      $��Total Pages Read: ��6'   $��22(�6B   $��Light"�6P   $��	helvetica)�6c   
�����f�6�   5-      �� 5/   
   $	��Top=�6   $��
10,210,0,0q�6-   .+�50      �� -   5        $ Booksfinished��50      $��Books Finished: ��6/   $��22(�6G   $��Light"�6U   $��	helvetica)�6h   
�����f�6�   51      �� 53   
   $	��Top=�6   $��
10,250,0,0q�6-   .+�54      �� -   5        $ favouriteautor��54      $��Favourite autor(s): ��60   $��22(�6L   $��Light"�6Z   $��	helvetica)�6m   
�����f�6�   55      �� 56   
   -   5        $��	10,15,0,0q�56      $	��100��6%   $��40��61   $��Edit Profile��6=   $	��Top=�6U   $
��Left=�6m   6�   �� 57   
   -	   5        $��	10,60,0,0q�57      $	��100��6%   $��40��61   $��	Main Menu��6=   $	��Top=�6R   $
��Left=�6j   6�     OxyPlot.Wpf.Plot  58   
   -
   5          Name$ myPlot��58      $��Bottom=�6;   $	��200��6V   $	��520��6c      Title 6#   �� *Title+   Series 59        OxyPlot.Wpf.ColumnSeries  5:        OxyPlot.Wpf.BarSeriesBase   LabelFormatString$ Pages ��6#      LabelPlacement$ Inside=�6>      	FillColor$ MediumAquamarine��6v   ��6V   �� *	Columns+6v   5<      5>      5?      