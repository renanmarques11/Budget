   M S B A M L   `   `   `  ����F  BChallenge_5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Challenge_5.ViewsChallenge_5.Views  5   	   &     Challenge_5.Views.NewBudget_View   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Challenge_5.Views     5   	     � Title$  NewBudget_View��5   	   $	��450��6    $	��800��6-   .��5	      �  � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��60 �6   �� 5      $��60 �6   .+�5   
   �� $��/Images/imagem.jpg��6   $
��Fill=�6,    J� Opacity$
 0.32Q�6<   $��0��5      $��2��6    $��0��5      $��7��6   �� 5   
   $��Budget Registration��6   $��25(�5      $��Center=�5       $��Center=�5!      $
��Bold"�5"      $��0��5#      $��2��5$      ���#3212405%      �� 5'   
   $��Name (Budget):��6   $��1��6(   $��0��65   $��5q�6E   $��14(�6P   $
��Bold"�6^   $��Center=�6p   {�.  
�������6�   �� 5(   
   $��1��6(   $��1��65   $��5q�6E   $��14(�6P   ��6   �� *Name+6P   �� 5*   
   $��Amount (Budget)��6   $��2��6)   $��0��66   $��5q�6F   $��14(�6Q   $
��Bold"�6_   $��Center=�6q   {�.  
�������6�   �� 5+   
   $��2��6A   $��1��6N   $��5q�6^   $��14(�6i   ��6   �� *Amount+ �� StringFormat$ {0:C}��6i   �� 5-   
   $&�� Type (0 - Revenue / 1 - Expense)��6   $��3��6:   $��0��6G   $��5q�6W   $��14(�6b   $
��Bold"�6p   $��Center=�6�   {�.  
�������6�   �� 5.   
   $��3��6(   $��1��65   $��5q�6E   $��14(�6P   ��6   �� *Type+6P   �� 56   
   $
��Save��57      $��5��58      $��2��59      $��270, 10q�5:      ���#4A7A8C$��0q�5<      ��56      �� *SaveInsertCommand+5<      �� 5>   
   -   5        $��Close��5>      $��6��5?      $��2��5@      $��270, 10q�5A      ���#4A7A8C$��0q�5C      6%   5F      5G      