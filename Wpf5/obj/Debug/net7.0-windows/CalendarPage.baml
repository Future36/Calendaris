   M S B A M L   `   `   `  ����J  FCalendarProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CalendarProgramCalendarProgram  5      "    CalendarProgram.CalendarPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:CalendarProgram     5        N� Title$  Pagee��5	      .��5      � ���#F0F0F0 � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� -   5        $��
BackButton��5      $��0��6#   $��0��60   $��10q�6@   $
��Left=�6L   $��30��6g   $��30��6r   ��5      �� 5       �� 
TargetType" ��6"   .R�5      � ���#007AFF.+�5      ��  �� CornerRadius$ 15��6!   ._�5      �� $��	/left.png��6$   $��20��67   $��20��6B   $��5q�6N   5      5      5      5       (  "System.Windows.Controls.DatePicker  5"   
   -   5        $��
DatePicker��5"      $��0��6'   $��1��64   $��10q�6D   $��30��6P   $��18(�6�      IsTodayHighlighted$ False��6�   �� 5$   
   -   5        $��
NextButton��5$      $��0��6#   $��2��60   $��10q�6@   $��Right=�6L   $��30��6h   $��30��6s   ��5%      �� 5&      " ��6"   .R�5'      � ���#007AFF.+�5(      �� $ 15��6!   ._�5)      �� $��
/right.png��6$   $��20��68   $��20��6C   $��5q�6O   5*      5+      5,      5.      �� 51   
   -   5        $��	DaysPanel��51      $��1��6#   $��3��60   $��10q�6D    �� SelectionMode$ Extended=�6�   $��Disabled=�6�   ��52      �� 53      " ��6"   .R�54      �� ���#E5E5E5$��1q�63   
�������$ 10��6Z   ._�55      �� .��56      �� 57      58      59      ��5;      �� 5<      .R�5=      � 5>      ��5@      �� 5A       �� 
TargetType" ��6   .�5B      ��  �� Property � ��	 �� Value$	 5q�6/   �� 5C       � ��$	 10q�60   �� 5D       � ��	 �#E5E5E564   �� 5E       � ��$	 1q�68   �� 5F       � ��
	 �����63   �� 5G       � ��	 5H      �� 5I      " ��6.   .R�5J   "   �� #��z��6)   #��z��6S   #��z��6   $ 10��6�   ._�5K   &   �� $��Center=�67   $��Center=�6T   5L   #   5M      5O      
 �� Triggers
 5P      P� 5Q       P� Property �@��
IsSelected P� Value$
 True��68   . �5R      ��  � ��	 �#007AFF6;   �� 5S       � ��
	 �����6;   5T      5V      5X      5Y      5Z      