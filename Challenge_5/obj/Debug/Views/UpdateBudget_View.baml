   M S B A M L   `   `   `  ����F  BChallenge_5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Challenge_5.ViewsChallenge_5.Views  5   	   ?$clr-namespace:Challenge_5.ViewModelsChallenge_5.ViewModels  67   )    #Challenge_5.Views.UpdateBudget_View   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Challenge_5.Views     5   	   ;
viewmodels$clr-namespace:Challenge_5.ViewModels     67     � Title$  UpdateBudget_View��5   	   $	��450��6#   $	��800��60   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   �� $��/Images/imagem.jpg��6   $
��Fill=�6,    J� Opacity$
 0.32Q�6<   $��0��5      $��4��6    $��0��5      $��5��6   �� 5   
   $!��RM Technology - Budget 2022��6   $��25(�5       $��Center=�5!      $��Center=�5"      $
��Bold"�5#      $��0��5$      $��4��5%      ���#3212405&      �� 5)   
   $
��Type��6   $��1��5*      $��10q�5+      $��14(�5,      $
��Bold"�5-      $��Center=�5.      $��Bottom=�5/      ���#321240{�.  
�������50   9   �� 52   
   $	��Top=�63   $��2��53      $��10q�54      $��14(�55      $
��Bold"�56      ���#321240��52      �� *BudgetDto.Type+57      �� 59   
   $��Budget��6   $��1��5:      $��1��5;      $��10q�5<      $��14(�5=      $
��Bold"�5>      $��Center=�5?      ���#321240{�.  
�������5@   9   �� 5B   
   $	��Top=�62   $��2��5C      $��1��6   $��10q�5D      $��14(�5E      $
��Bold"�5F      ���#321240��5B      �� *BudgetDto.Name+5G      �� 5I   
   $��Amount��6   $��1��5J      $��2��5K      $��10q�5L      $��14(�5M      $
��Bold"�5N      $��Center=�5O      ���#321240{�.  
�������5P   9   �� 5R   
   $	��Top=�6K   $��2��5S      $��2��6   $��10q�5T      $��14(�5U      $
��Bold"�5V      ���#321240��5R      �� *BudgetDto.Amount+ �� StringFormat$ {0:C}��5W      �� 5Y   
   $��Balance��6   $��1��5Z      $��3��5[      $��10q�5\      $��14(�5]      $
��Bold"�5^      $��Center=�5_      ���#321240{�.  
�������5`   9   �� 5b   
   $	��Top=�6Y   {�.  $��2��5c      $��4��6   $��10q�5d      $��14(�5e      $
��Bold"�5f      ���#321240��5b      �� *BudgetDto.Balance+ �� Mode$ OneWay=�$ {0:C}��5g      &   System.Windows.Controls.DataGrid  5i   
   $��3��5k         AutoGenerateColumns .  $��4��5m      $��10q�5n       �� SelectedValue 5i      �� *SelectedItem+��5j      �� *BudgetDto.Items+   Columns 5q      0  *System.Windows.Controls.DataGridTextColumn  5r      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Item��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 auto 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L     5s      $	 Amount��6%   $

 auto 6g    65   �� *Amount+$ {0:C}��6g   5v      �� 5x   
   $
��Save��5y      $��4��6    $��1��5z      $��10q�5{      ���#4A7A8C$��0q�5}      ��5x      �� *SaveUpdateCommand+5}      �� 5   
   $��Delete Item��5�      $��4��5�      $��2��6   $��10q�5�      ���#4A7A8C$��0q�5�      ��5      �� *DeleteItemCommand+5�      5�      5�      