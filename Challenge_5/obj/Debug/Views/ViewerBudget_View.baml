   M S B A M L   `   `   `  ����F  BChallenge_5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Challenge_5.ViewsChallenge_5.Views  5   	   )    #Challenge_5.Views.ViewerBudget_View   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Challenge_5.Views     5   	     � Title$  ViewerBudget_View��5   	   $	��450��6#   $	��800��60   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   �� $��/Images/imagem.jpg��6   $
��Fill=�6,    J� Opacity$
 0.32Q�6<   $��0��5      $��4��6    $��0��5      $��5��6   �� 5   
   $!��RM Technology - Budget 2022��6   $��25(�5      $��Center=�5      $��Center=�5       $
��Bold"�5!      $��0��5"      $��4��5#      ���#3212405$      �� 5'   
   $
��Type��6   $��1��5(      $��10q�5)      $��14(�5*      $
��Bold"�5+      $��Center=�5,      $��Bottom=�5-      ���#321240{�.  
�������5.   9   �� 50   
   $	��Top=�63   {�.  $��2��51      $��10q�52      $��14(�53      $
��Bold"�54      ���#321240��50      �� *BudgetDto.Type+55      �� 57   
   $��Budget��6   $��1��58      $��1��59      $��10q�5:      $��14(�5;      $
��Bold"�5<      $��Center=�5=      ���#321240{�.  
�������5>   9   �� 5@   
   $	��Top=�62   {�.  $��2��5A      $��1��6   $��10q�5B      $��14(�5C      $
��Bold"�5D      ���#321240��5@      �� *BudgetDto.Name+5E      �� 5G   
   $��Amount��6   $��1��5H      $��2��5I      $��10q�5J      $��14(�5K      $
��Bold"�5L      $��Center=�5M      ���#321240{�.  
�������5N   9   �� 5P   
   $	��Top=�6K   {�.  $��2��5Q      $��2��6   $��10q�5R      $��14(�5S      $
��Bold"�5T      ���#321240��5P      �� *BudgetDto.Amount+ �� StringFormat$ {0:C}��5U      �� 5W   
   $��Balance��6   $��1��5X      $��3��5Y      $��10q�5Z      $��14(�5[      $
��Bold"�5\      $��Center=�5]      ���#321240{�.  
�������5^   9   �� 5`   
   $	��Top=�6Y   {�.  $��2��5a      $��4��6   $��10q�5b      $��14(�5c      $
��Bold"�5d      ���#321240��5`      �� *BudgetDto.Balance+ �� Mode$ OneWay=�$ {0:C}��5e      &   System.Windows.Controls.DataGrid  5g   
   $��3��5i         AutoGenerateColumns .  $��4��5k      $��10q�5l       �� SelectedValue 5g      �� *SelectedItem+��5h      �� *BudgetDto.Items+   Columns 5o      0  *System.Windows.Controls.DataGridTextColumn  5p      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Item��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 auto 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L     5q      $	 Amount��6%   $

 auto 6g    65   �� *Amount+$ {0:C}��6g   5t      �� 5v   
   -   5        $��Close��5w      $��4��6!   $��1��5x      $��2��5y      $��100,10,100,10q�5z      ���#4A7A8C$��0q�5|      ��5v      �� *CloseCommand+5|   %   5      5�      