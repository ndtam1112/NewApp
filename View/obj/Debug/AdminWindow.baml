   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5   	       View.AdminWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:View     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��
Imageadmin��5   	   
�������  � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  � Title$ AdminWindow��5   	   $	��621��6   $
��1000��6*   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �  � RowDefinitions 5      �� 5      $��3* �6    �� 5      $��* �6    �� 5      $��2* �6    �� 5      $��* �6    .+�5      �� $	��250��6   $	��250��6!   $��1q�6.   $��0 10 0 0q�6B   
�������._�5      �� -   5         ��Name$ Image_product_main��5      $;��5image\SanPham\Short\Casual-Reflection-Short-Black.png��5      $��Uniform=�5       5!      �� 5"      -   5         ��Name$ btnAddThumb_Main��5"   L   
�������$��50��6'   $	��150��63   $��1��6?      LatoThin#��[  5#   !   $��Add main thumb��6H   +  %MaterialDesignThemes.Wpf.ButtonAssist	   CornerRadius$	 20��5$   !    ! MaterialDesignFlatButtonClick#��[ 6O   � 5%      $��2��6    5&      �� 5'      �� 5(      .+�5*      �� $��1q�6   
�������$��10q�6@   ._�5+      �� -   5        $ Image_Sub_1��5,      $;��5image\SanPham\Short\Casual-Reflection-Short-Black.png��5+      $��Uniform=�5-      5.      �� 5/      $��1q�6   $��1��6-   
�������$��10q�6P   ._�50      �� -   5        $ Image_Sub_2��51      $;��5image\SanPham\Short\Casual-Reflection-Short-Black.png��50      $��Uniform=�52      53      54      � 55      $��3��6    56      �� 57      �� 58      .+�5:      �� -   5        $ btnAddThumb2��5:   8   
�������$��50��6   $	��150��6+   #��[  5;   !   $��Add thumb 2��6H   $	 20��5<   !   #��[ 6O   �� 5=      -   5        $ btnAddThumb3��5=   5   
�������$��50��6   $	��150��6)   #��[  5>   !   $��Add thumb 3��6H   $��1��6^   $	 20��5?   !   #��[ 6O   5@      5A      �� 5B   
   $��1��6   $
��0 50q�6%   .+�5C      �� 
�������$	��120��6(   $��50��64   $
��Left=�6@   $��1q�5D      
�������
 �� CornerRadius$
 20��6=   $��10q�6O   ._�5E      �� -   5         ��Name$ 
Id_product��5F   7   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 SKU��5E      $��0q�5F      $��15(�6)   $	��280��5G      $��10 5 0 0q�6+   $��Center=�5H      $
��Left=�69   $��1��5I      .��6.   5J      5K      �� 5L      
�������$	��120��6(   $��50��64   $
��Left=�6@   $��1q�5M      
�������$
 20��6=   $��10q�6O   ._�5N      �� -	   5        $ Mount_product��5O   7   $ Mount��5N      $��0q�5O      $��15(�6)   $	��280��5P      $��10 5 0 0q�6+   $��Center=�5Q      $
��Left=�69   $��1��5R      .��6.   5S      5T      �� 5U      
�������$	��400��6(   $��60��64   $
��Left=�6@   $��1q�5V      
�������$
 20��6=   $��10q�6O   ._�5W      �� -
   5        $ Name_product��5X   7   $ Name Product��5W      $��0q�5X      $��15(�6)   $	��280��5Y      $��10 5 0 0q�6+   $��Center=�5Z      $
��Left=�69   $��1��5[      .��6.   5\      5]      �� 5^      
�������$	��400��6(   $��60��64   $
��Left=�6@   $��1q�5_      
�������$
 20��6=   $��10q�6O   ._�5`      �� -   5        $ Price_product��5a   7   $ Price Product��5`      $��0q�5a      $��15(�6)   $	��280��5b      $��10 5 0 0q�6+   $��Center=�5c      $
��Left=�69   $��1��5d      .��6.   5e      5f      � 5g       5h      �� 5i      �� 5j      .+�5l      �� -   5         ��Name$ 
cbCategory��5m   #   $��20(�5l      $��30q�6)    & "MaterialDesignFloatingHintComboBox#��[ 5n      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .   SecondaryHueMidBrush   UnderlineBrush# �  5p      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Inverted=�5q      $ Category��5r         
HelperText$ Select one Category��5s      $	��100��5t      $��Center=�6!   .@�5u      �� $��TShirt��6#   �� 5v      $��Short��6#   �� 5w      $��Sweater��6#   �� 5x      $��Pants��6#   �� 5y      $��Jacket��6#   �� 5z      $	��Bag��6#   5{      5~      �� 5      -   5        $ btnAdd_product��5   7   
�������$��50��6   $	��150��6*   #��[  5�   !   $
��Save��6H   $	 20��5�   !   #��[ 6O   5�      5�      5�      