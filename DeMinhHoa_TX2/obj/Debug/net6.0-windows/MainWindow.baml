   M S B A M L   `   `   `  ����H  DDeMinhHoa_TX2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DeMinhHoa_TX2DeMinhHoa_TX2  5   	       DeMinhHoa_TX2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DeMinhHoa_TX2     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$( "Bài kiểm tra thường xuyên 2��5	   	   $	��450��6-   $	��800��6:    � 	Resources 5
         BoldHeaderStyle �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Property �� Value  styleButton �� 
TargetType��%�  &	        &	 r     �� 5   
   "  6(   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ Center=�6;   5      �� 5   
   " ��6$   .�5      ��  � ��
 � � �6+   �� 5       � ��$ 25��6'   �� 5       � ��$ 40��6&   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      A� 
��� ���$
��Bold"�62   �� 5      $��Center=�6/   $��Center=�6L   5      5      5      5      5      .��5      �  � RowDefinitions 5    
   �� 5!      $
��auto �6   6,   �� 5"      6   �� 5#      $
��auto �6   6,   .+�5%   
   � $��0��6   .+�5&      �� $��40(�6   
����  �$��Center=�68   #!Quản lý thông tin nhân viên6r   5'      � 5(   
   $��1��6   .+�5)      �� $��10q�6   
��� � �$��1q�65   
�������._�5*      �� $��
20,50,20,0q�6   .+�5,      ��  �� Orientation$ 
Horizontal=�6!   .+�5-      �� $��Mã nhân viên:��6$   $	��100��69   �� 5.      -   5        	 ��Name$	 txtMaNV��5.   "   $	��200��63   5/      �� 51      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�52      �� $��Họ và tên:��6$   $	��100��66   �� 53      -   5        $	 txtHoTen��53   "   $	��200��64   54      �� 56      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�57      �� $��Ngày sinh:��6$   $	��100��66   (  "System.Windows.Controls.DatePicker  58      -   5        
  Name$
 
dpNgaySinh��58   %   $	��200��69   59      �� 5;      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5<      �� $��Giới tính:��6$   $	��100��66   	� 5=      -   5         	�Name$ rbNam��5=   &   $	��Nam��65    	� 	GroupName$ Gender��6C   	� 5>      -   5        $
 rbNu��5>   &   $
��Nữ��64   $ Gender��6A   $��10,0,0,0q�6T   5?      �� 5A      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5B      �� $��Phòng ban:��6$   $	��100��66   �� 5C      -   5         ��Name$ 
cbPhongBan��5C   #   $	��200��67   .@�5D      �� $��Tổ chức��6+   �� 5E      $��Kế hoạch��6+   �� 5F      $��Vật��6+   5G      5H      �� 5I      $ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5J      �� $��Hệ số lương:��6$   $	��100��68   �� 5K      -   5        $	 txtHeSoLuong��5K   "   $	��200��68   5L      �� 5M      $��	5 10 5 10q�6!   .+�5N      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5N   #      AutoGenerateColumns$ False��65      ColumnHeaderStyle# [  6Q      Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Mã nhân viên��65      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6k   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *
MaNhanVien+6k     5Q   "   $ 	Họ tên��65   $	 150 6a    6E   �� *HoTen+6a     5R   "   $ Giới tính��65   $	 100 6h    6H   �� *
GioiTinh+6h     5S   "   $ 
Phòng ban��65   $ 80 6g    6I   �� *
PhongBan+6g     5T   "   $ 
Ngày sinh��65   $ 70 6~    6H   �� *
NgaySinh+ �� StringFormat$ 
dd/MM/yyyy��5V   #     5W   "   $ Tuổi��65   $	 115 6^    6C   �� *Tuoi+   ElementStyle 5X   &   �� 5Y   *   " ��60   .�5Z   .   ��  � ��
 �  ��6K   �� 5[   .    � ��$ Right=�6T   �� 5\   .    � ��$
 Bold"�6K   5]   +   5_   #   5a      5b      5c      5d      5e      � 5f   
   $��2��6   .+�5g      �� $��10q�6   $��Center=�6%   $ 
Horizontal=�6B   .+�5h      �� -	   5         ��Name$
 Nhap��5h   Y   #��[ 6   $��70��6?   $��Nhập��6J   6g   �� 5i      -
   5        $ Window2��5i   o   #��[ 6   $��10 0 0 0q�6?   $��70��6Q   $��Window 2��6\   6�   5j      5k      5l      5m      