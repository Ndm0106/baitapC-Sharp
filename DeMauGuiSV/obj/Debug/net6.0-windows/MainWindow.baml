   M S B A M L   `   `   `  ����E  ADeMauGuiSV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DeMauGuiSV
DeMauGuiSV  5   	       DeMauGuiSV.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DeMauGuiSV     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Course Exam��5
   	   $	��550��6   $	��800��6*    � 	Resources 5       �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Triggers P� Property P� Value	 �� 
TargetType��%�  '��       '  �     '��     '�� u    '�� T    �� 5   
   " ��6   .�5      ��  � ��$ 35(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�64   5      �� 5   
   "  6   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ Center=�6;   5      �� 5   
   " ��6   .�5      ��  � ��$	 135��6&   �� 5       � ��$ 20(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 20(�6)    5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � ��
 �  ��63   �� 5       � ��
 � ���63   5      5!      �� 5"   
   " ��6   .�5#      ��  � ��$ 80��6&   �� 5$       � ��$ 30��6'   �� 5%       � ��$ 10q�6'   �� 5&       � ��$ SemiBold"�6+   �� 5'       � �� 5(      �� 5)      "	 ��6&   .R�5*      � .+�5+      A� 
����� �6&   �� 5,      $��Center=�6/   $��Center=�6L   5-      5.      50      51      52      .��53      � 
 � RowDefinitions
 54   
   �� 55      $
��auto �6   �� 56      $
��auto �6   �� 57      �� 58      $
��auto �6   .+�5:   
   � $��0��6   .+�5;      �� $��SALES MANAGEMENT��6   $��0 35 0 0q�60   5<      � 5=   
   $��1��6   .+�5>      �� $��
170 0 0 20q�6   .+�5?      ��  �� Orientation$ 
Horizontal=�6   $��0 10 0 0q�66   .+�5@      �� $��	ProductID��6   �� 5A      -   5         ��Name$ txtID��5A      $	��300��6-   5B      �� 5C      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5D      �� $��Product Name��6   �� 5E      -   5        $ txtName��5E      $	��300��6/   5F      �� 5G      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5H      �� $��
Unit Price��6   �� 5I      -   5        $ txtUnitPrice��5I      $	��300��64   5J      �� 5K      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5L      �� $��Quantity��6   �� 5M      -   5        $ txtQuantity��5M      $	��300��63   5N      �� 5O      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5P      �� $��Category��6   �� 5Q      -   5         ��Name$ cbxCategory��5Q      $��20(�64   $	��300��6B   5R      5S      5T      � 5U   
   $��2��6   $��10q�6   .+�5V      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataInfor��5V         AutoGenerateColumns$ False��6*      CanUserAddRows$ False��6F      Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Product ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *	ProductId+6[     5Y      $ Product Name��6)   $	 150 6_    6?   �� *ProductName+6_     5Z      $ Category ID��6)   $	 100 6X    6>   �� *CatId+6X     5[      $ 
Unit Price��6)   $	 100 6[    6=   �� *	UnitPrice+6[     5\      $ Quantity��6)   $	 100 6X    6;   �� *
Quantity+6X     5]      $ Amount��6)   $	 100 6j    69   �� *Amount+ �� StringFormat$ {0:N0}��   ElementStyle 5^      �� 5_      " ��6$   .�5`   "   ��  � ��$ Right=�6H   �� 5a   "    � ��$
 Bold"�6?   �� 5b   "    � ��$ Italic$�6>   �� 5c   "    � ��
 ��  �6?   5d      5f      5h      5i      � 5j   
   $��3��6   $��10q�6   .+�5k      �� $ 
Horizontal=�6   $��Center=�62   .+�5l      �� -   5         ��Name$ 	btnInsert��5l      $��Insert��6,   6=   �� 5m      -   5        $ 	btnUpdate��5m      $��Update��6,   6=   �� 5n      -	   5        $ 	btnDelete��5n      $��Delete��6,   6=   �� 5o      -
   5        $ 	btnSearch��5o      $��Search��6,   6=   5p      5q      5r      5s      