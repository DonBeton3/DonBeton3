   M S B A M L   `   `   `  ����G  CSportKursach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SportKursachSportKursach  5          SportKursach.FullInfoPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:SportKursach     5        N� Title$  AddPage��5	      .��5      � -   5         �Name$ FullInfoPage1��5       � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��9* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��12* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $	��20* �6   .+�5   
   � $��0��6   $��0��6   $��2��6,   $��0,0,95,0q�6@   .+�5      ��    HeaderLabelStyle#��[  6   $��12(�6>   $	��127��6L   .��6X   Назва змагання6h   5      � 5   
   $��0��6   $��2��6   $��125.5,0,0,0q�60   .+�5      �� #��[  6   $��12(�6?   $��	25,12,0,0q�6M   $	��137��6a   .��6m   Вид спорту6y   5      � 5   
   $��0��6   $��1��6   $��3��6,   $��	-28,0,0,0q�6@   .+�5       �� #��[  6   $��10(�6?   .��6M   '%Кількість учасників6b   5!      � 5"   
   $��0��6   $��3��6   $��2��6,   $��
-180,0,0,0q�6@   .+�5#      �� #��[  6   $��10(�6?   .��6M   !Місце проведення6_   5$      � 5%   
   $��0��6   $��3��6   $��2��6,   $��	112,0,0,0q�6@   .+�5&      �� $	��180��6   $��	40,10,0,0q�6    #��[  64   $��11(�6_   .��6m   Дата проведення6~   5'      5(      � 5)   
   $��1��6   .+�5+      � $��1��6   .+�5,      &   System.Windows.Controls.DataGrid     CanUserAddRows$ False��6w      AutoGenerateColumns$ False��6�      HeadersVisibility$
 None=�6�      	RowHeight$ 30Q�6�      GridLinesVisibility$ 
Horizontal=�6�   $��0,35,0,-390q�6�   
���������6   �� *YourListOfCompetitions+	 �� SelectedItem	 6J   �� *SelectedCompetition+
   Columns
 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 124 6)      Header$! Назва змагання��65      
IsReadOnly$
 True��6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6_   �� *Name+   ElementStyle 5/      �� 50       �� 
TargetType" ��6$   .�51   "   ��  �� Property � �� �� Value$ Center=�6H   52      54        55      $ 95 6)   $ Вид спорту��64   $
 True��6H    6Z   �� *Kind+ 56      �� 57      " ��6$   .�58   "   ��  � ��$ Center=�6H   59      5;        5<      $	 115 6)   $+ %Кількість учасників��65   $
 True��6R    6d   �� *	Members+ 5=      �� 5>      " ��6$   .�5?   "   ��  � ��$ Center=�6H   5@      5B        5C      $	 119 6)   $% Місце проведення��65   $
 True��6O    6a   �� *Place+ 5D      �� 5E      " ��6$   .�5F   "   ��  � ��$ Center=�6H   5G      5I        5J      $	 150 6)   $# Дата проведення��65   $
 True��6N    6`   �� *Date+ 5K      �� 5L      " ��6$   .�5M   "   ��  � ��$ Center=�6H   5N      5P         RowStyle 5R      �� 5S      )  #System.Windows.Controls.DataGridRow"  6   .�5T      -   5        5U      5W      5X      5Y      5Z      5[      