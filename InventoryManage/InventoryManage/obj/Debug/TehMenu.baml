   M S B A M L   `   `   `  ����J  FInventoryManage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:InventoryManageInventoryManage  5   	       InventoryManage.TehMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:InventoryManage     5   	     � Title$  TehMenu��5   	   $	��450��6   $	��800��6&   .��5	      � ���#C8D1FF � RowDefinitions 5
   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� -   5         ��Name$
 exit��5      ���#97A6F4$��
Выйти��6G   $��Manrope)�6W   
�������$��0��6   $��0��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 20��65   5       5!      5"      &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ Applications��5#      $��1��6Z   $��0��6g   $��5��6w   $��7��6�   �� 5$   
   -   5        	 ��Name$	 status��5$   >   $��0��6N   $��1��6[   $��2��6k   �� 5%   
   -   5        $	 classes��5%   =   $��0��6N   $��3��6[   $��2��6k   �� 5'   
   -   5        $	 statusChange��5'      $��8��6*   $��0��67   $��2��6G   �� 5(   
   -   5        $ change��5(      ���#97A6F4$#��Изменить статус��66   $��Manrope)�6P   
�������$��8��6x   $��2��6�   $��3��6�    5)      ��%_   '��       �� 5*      " ��6   .�5+      ��  �@��CornerRadius$ 20��65   5,      5-      5.      5/      50      