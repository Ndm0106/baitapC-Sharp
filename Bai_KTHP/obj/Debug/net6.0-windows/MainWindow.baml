   M S B A M L   `   `   `  ����C  ?Bai_KTHP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Bai_KTHPBai_KTHP  5   	       Bai_KTHP.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Bai_KTHP     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$' !Bài thi kết thúc học phần��5	   	   $	��550��6+   $	��800��68    � 	Resources 5
       �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� CornerRadius   triggerTxtMaHS �� Triggers	 P� Property
 P� Value��%F  '��       '  m     '�� �     &	  f    �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   �� 5       � ��$	 210��6&   5      �� 5   
   "  6   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ Center=�6;   5      �� 5   
   " ��6   .�5      ��  � ��$ 30��6'   �� 5       � ��$ 16(�6)   �� 5       � ��$	 100��6&   �� 5       � ��$ 10 0 0 0q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� 
����� �
��� � �$��2q�6G   $ 5��6[   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5!      �� 5"   
   " ��6    5#      P� 5$      	 �@J�IsMouseOver$

 True��61   . �5%      ��  � ��
 ��ح�63   �� 5&       � ��
 �����63   5'      5)      5*      .��5+      �  � RowDefinitions 5,   
   �� 5-      $
��auto �6   �� 5.      �� 5/      $
��auto �6   .+�51   
   � $��0��6   .+�52      �� $��0 10 0 0q�6   $��QUẢN LÝ HỌC SINH��6*   $��40(�6B   
��� � �$��SemiBold"�6c   $��Center=�6y   53      � 54   
   $��1��6   .+�55      �� $��10q�6   .+�56      ��  �� Orientation$ 
Horizontal=�6   $��0 10 0 0q�66   .+�57      �� $��Mã học sinh:��6   �� 58      -   5         ��Name$ txtMaHS��58   F   #��[  6   $	��200��6W   $��25��6c   $��16(�6o   59      �� 5:      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5;      �� $��
Họ tên:��6   �� 5<      -   5        $ txtHoTen��5<      $	��300��60   $��25��6<   $��16(�6H   5=      �� 5>      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5?      �� $��Ngày sinh:��6   (  "System.Windows.Controls.DatePicker  5@      -   5          Name$ 
dpNgaySinh��5@   !   $��16(�65   5A      �� 5B      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5C      �� $��Giới tính:��6   �� 5D      $ 
Horizontal=�6!   $��0 10 0 0q�6:   .+�5E      	� -   5         	�Name$ rbNam��5E   &   .��65   Nam6:   	� 5F      -   5        $
 rbNu��5F   &   $��10 0 0 0q�64   .��6F   Nữ6J   5G      5H      �� 5I      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5J      �� $$��Con thương binh liệt sỹ:��6   �� 5K      -   5         ��Name$ 	cbConTBLS��5K      $��0 10 0 0q�62   5L      �� 5M      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5N      �� $��Lớp:��6   �� 5O      -   5         ��Name$ cbxLop��5O      $	��200��6/   $��25��6;   $��16(�6G   5P      �� 5Q      .+�5R      &   System.Windows.Controls.DataGrid  -   5          Name$ dataHocSinh��5R   ,   $	��100��6      AutoGenerateColumns$ False��6A   $��0 10 0 0q�6]      Columns 5S      0  *System.Windows.Controls.DataGridTextColumn  5T      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã học sinh��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *MaHs+  5U      $ 	Họ tên��61      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6[    6A   �� *HoTen+6[     5V      $ 
Ngày sinh��61    6D   �� *
NgaySinh+ �� StringFormat$ 
dd-MM-yyyy��   ElementStyle 5W   "   �� 5X   &   " ��6,   .�5Y   *   ��  � ��
 �  ��6G   5Z   '   5\        5]      $ Giới tính��61    6D   �� *
GioiTinh+  5^      $# Con thương binh liệt sỹ��61    6R   �� *	ConTbls+  5_      $ 
Tên lớp��61    6B   �� *TenLop+  5`      $ Tuổi��61    6?   �� *Tuoi+5b      5c      5d      5f      � 5g   
   $��2��6   .+�5h      �� $��20q�6   $ 
Horizontal=�6%   $��Center=�6>   .+�5i      �� -	   5         ��Name$ btnThem��5i      $��Thêm��6@   �� 5j      -
   5        $ 
btnThongKe��5j      $��Thống kê��6F   5k      5l      5m      5n      