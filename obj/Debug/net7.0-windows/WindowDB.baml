   M S B A M L   `   `   `  ����H  DDataBaseOnWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DataBaseOnWPFDataBaseOnWPF  5   	       DataBaseOnWPF.WindowDB   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DataBaseOnWPF     5   	     � Title$$  Окно Базы Данных��5   	   $	��670��6"   $	��660��6/   ���	#FF3567D6 � WindowStartupLocation$ CenterScreen=�5	   	   .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dataGridDb��5   *      AutoGenerateColumns$ false��5      $��3��5      $��0��6   $��3��5   8    J� RenderTransformOrigin$ 0.495,0.519&�5      $��
10,0,10,40q�61      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 61   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *Id+  5      $ Название��6%   $	 * 67   
 6A   �� *Name+  5      $ Тип��6%   $	 * 62   
 6<   �� *Type+  5       $ Цвет��6%   $	 * 63   
 6=   �� *Color+  5!      $ Калории/100г��6%   $	 * 6;   
 6E   �� *
Calories+5#      �� 5%   
   -   5         ��Name$ 	btnUpdate��5%   .   $��1��6   $��0��6   $��Обновить��6B   $��	10,20,0,0q�6V   $
��Left=�6i   $	��Top=�6�   $	��130��6�   $��25��6�   
�������6�   �� 5&   
   -   5        $ btnAdd��5&   .   $��1��6   $��0��6   $��Добавить��6B   $��
180,20,0,0q�6V   $
��Left=�6j   $	��Top=�6�   $	��130��6�   $��25��6�   
�������6�   �� 5'   
   -   5        $ 	btnDelete��5'   .   $��1��6   $��0��6   $��Удалить��6B   $��
0,20,180,0q�6V   $��Right=�6j   $	��Top=�6�   $	��130��6�   $��25��6�   
�������6�   �� 5(   
   -   5        $ btnSave��5(   .   $��1��6   $��0��6   $��Сохранить��6B   $��
0, 20,10,0q�6V   $��Right=�6j   $	��Top=�6�   $	��130��6�   $��25��6�   
�������6�   �� 5)   
   $��2��6   $��0��6   $*��$Выведенная таблица:��6.   $
��Left=�6L   $��	10,15,0,0q�6g   $	��Top=�6z   $	��267��6�   $��35��6�   $��16(�6�   �� 5*   
   -   5        $ btnClose��5*   .   $��5��6   $��0��6   $��
Выход��6B   $��Right=�6R   $��	0,0,10,10q�6o   $��Bottom=�6�   $	��150��6�   $��20��6�   
��� � �6�   �� 5+   
   -   5         ��Name$ 
labelLogin��5+   .   $��4��6   $��0��6   $��Пользователь��6B   $
��Left=�6Y   $��10,0,0,0q�6t   $��Bottom=�6�   $	��300��6�   $��30��6�   $��14(�6�   
�������6�   5-      5.      