   M S B A M L   `   `   `  ����H  DDataBaseOnWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DataBaseOnWPFDataBaseOnWPF  5   	       DataBaseOnWPF.RegWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DataBaseOnWPF     5   	     � Title$  Регистрация��5   	   $	��330��5	   	   $	��450��6    � WindowState$ Normal=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   ���	#FF61AFEC � 	Resources 5       �� Source�� 5   
   $ 
Style.xaml?�6   %    .��5      ��    Style_StackPanel_Vertical#��[  6   .+�5   
   �� $��Регистрация��6     Style_Header#��[ 5      $��0,5,0,0q�6:   ���	#FFF9F9F9$��Center=�6b   � 5   
     Style_GridInputs#��[ 6   $��0,5,0,0q�69    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    .+�5#      �� $��0��6   $��0��6!   $��
Логин��5$        Style_LabelInput#��[ 5%      
���   �6>   �� 5&      -   5         ��Name$ textBox_Login��5&      $��0��6-   $��1��6:     Style_Input#��[ 5'      6;   �� 5)      $��1��6   $��0��6!   $��Пароль��5*      #��[ 5+      
���   �6>   �� 5,      -   5        $ textBox_Password��5,      $��1��60   $��1��6=   #��[ 5-      6;   �� 5/      $��2��6   $��0��6!   $%��Повторите Пароль��50      #��[ 51      
���   �6>   �� 52      -   5        $ textBox_RepeatPassword��52      $��2��66   $��1��6C   #��[ 53      6;   �� 55      $��3��6   $��0��6!   $��Имя��56      #��[ 57      
���   �6>   �� 58      -   5        $ textBox_Name��58      $��3��6,   $��1��69   #��[ 59      6;   �� 5;      $��4��6   $��0��6!   $��Фамилия��5<      #��[ 5=      
���   �6>   �� 5>      -   5        $ textBox_LastName��5>      $��4��60   $��1��6=   #��[ 5?      6;   5A      �� 5C   
     Style_StackPanel_Buttons#��[ 6   .+�5D      �� -   5        	 ��Name$	 btnReg��5D      $?��9Зарегистрировать пользователя��6%     Style_ButtonReg#��[ 5E      $	��220��6>   6J   5G      5H      5I      