   M S B A M L   `   `   `  ����I  EWpfMasteringIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfMasteringItWpfMasteringIt  5   	       WpfMasteringIt.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfMasteringIt     5   	   -   5          � Title$  Mastering It 2017��5   	   $	��700��6#   $
��1200��60    � WindowStartupLocation$ CenterScreen=�6=    � WindowState$ 	Maximized=�6b    � Icon$ it.jpg��6z    � WindowStyle$
 None=�6�    � Topmost .  � 
ResizeMode$ NoResize=�6�    � 	Resources 5	         ButtonStyle1 �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName  ButtonStyle2  ButtonStyle3  btnExit  btnMaximize  btnMinimize  btnPlusScoreDoiSo1  btnMinusScoreDoiSo1  ButtonStyle 	 	btnAnswer 
 btnBackward  
btnForward  ButtonStyleStartTime  ButtonStyleShowQuestion � Cursor��%�#  &	        &	 �    &	 p    &	 A    &	 �	    &	 )    &	 �    &	 3    &	 [    &		 �    &	
 ~    &	 4    &	 �    &	 v     �� 5
   
   " ��6%   .�5      �� 	 � ��
 5      �� 5      " ��6&   .R�5      � .+�5      �� $ 	rectangle��6(   ���	#FFF4F4F5
���   �6L   �� 5      #��z��6/   ��. # z 6�   #��z��6�   $&�� Tổng kết điểm các đội��6  5       5      P� 5       �@J�	IsFocused . 6;   P� 5       �@��IsDefaulted . 6=   P� 5       �@J�IsMouseOver . . �5   "   �� $ 	rectangle��69   	 � ��
 �	#FFCDCDCD6P   5      P� 5       � �� . . �5   "   �� $ 	rectangle��69   	 � ��
 �	#FFBBBBBB6P   5      P� 5       � {� .  6;   5      5      �� 5       	 � ��$
 14(�6)   �� 5!      	 � ��$

 Bold"�6+   �� 5"      	 � ��
 �	#FF8B8B8B6,   �� 5#      	 � ��

 �   �6+   �� 5$      	 � ��$
 25��6'   �� 5%      	 � ��$
 
10,0,10,20q�6'   5&      �� 5'   
   " ��6%   .�5(      �� 	 � ��
 5)      �� 5*      " ��6&   .R�5+      � .+�5,      �� $ 	rectangle��6(   ���	#FFF4F4F56;   �� 5-      #��z��6/   ��. # z 6�   #��z��6�   $��-��6  5.       5/      P� 50       �@J�	IsFocused . 6;   P� 51       �@��IsDefaulted . 6=   P� 52       �@��	IsDefault .  6;   P� 53       � �� . 6;   P� 54       � {� .  6;   56      58      59      �� 5:   
   " ��6%   .�5;      �� 	 � ��
 5<      �� 5=      " ��6&   .R�5>      � .+�5?      �� ���	#FFF4F4F56(   �� 5@      #��z��6/   ��. # z 6�   #��z��6�   $��+��6  5A       5B      P� 5C       �@J�	IsFocused . 6;   P� 5D       �@��IsDefaulted . 6=   P� 5E       �@J�IsMouseOver . 6=   P� 5F       � �� . 6;   P� 5G       � {� .  6;   5I      5K      5L      �� 5M   
   " ��6    .�5N      �� 	 � ��
 5O      �� 5P      " ��6&   .R�5Q      � .+�5R      �� $ btnExit��6(   ���	#FFC3C3C369   �� 5S      #��z��6/   ��. # z 6�   #��z��6�   $��X��6  5T       5U      P� 5V       �@J�	IsFocused . 6;   P� 5W       �@��IsDefaulted . 6=   P� 5X       �@J�IsMouseOver . . �5Y   "   �� $ btnExit��69   	 � ��
 �	#FFFD00006N   5Z      P� 5[       � �� . . �5\   "   �� $ btnExit��69   	 � ��
 �	#FFFF30306N   5]      P� 5^       � {� .  6;   5`      5b      5c      �� 5d   
   " ��6$   .�5e      �� 	 � ��
 5f      �� 5g      " ��6&   .R�5h      � .+�5i      �� $ 	rectangle��6(   ���	#FFC3C3C36;   �� 5j      #��z��6/   ��. # z 6�   #��z��6�   $	��⧠��6  5k       5l      P� 5m       �@J�	IsFocused . 6;   P� 5n       �@��IsDefaulted . 6=   P� 5o       �@J�IsMouseOver . . �5p   "   �� $ 	rectangle��69   	 � ��
 �	#FF7E7E7E6P   5q      P� 5r       � �� . . �5s   "   �� $ 	rectangle��69   	 � ��
 �	#FF6666666P   5t      P� 5u       � {� .  6;   5w      5y      5z      �� 5{   
   " ��6$   .�5|      �� 	 � ��
 5}      �� 5~      " ��6&   .R�5      � .+�5�      �� $ 	rectangle��6(   ���	#FFC3C3C36;   �� 5�      #��z��6/   ��. # z 6�   #��z��6�   $	��─��6  5�       5�      P� 5�       �@J�	IsFocused . 6;   P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . . �5�   "   �� $ 	rectangle��69   	 � ��
 �	#FF9999996P   �� 5�   "   	 � ��
 �	#FFEEEEEE6?   5�      P� 5�       � �� . . �5�   "   �� $ 	rectangle��69   	 � ��
 �	#FFB9B9B96P   �� 5�   "   	 � ��
 �	#FFE8E8E86?   5�      P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   " ��6+   .�5�      �� 	 � ��
 5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ btnPlusScoreDoiSo1��6(   
�������6D   �� 5�      #��z��6/   ��. # z 6�   #��z��6�   $��+��6  5�       5�      P� 5�       �@J�	IsFocused . 6;   P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . . �5�   "   �� $ btnPlusScoreDoiSo1��69   	 � ��
 �	#FFFFCECE6Y   5�      P� 5�       � �� . 6;   P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   " ��6,   .�5�      �� 	 � ��
 5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ 	rectangle��6(   
�������6;   �� 5�      #��z��6/   ��. # z 6�   #��z��6�   $��-��6  5�       5�      P� 5�       �@J�	IsFocused . 6;   P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . . �5�   "   �� $ 	rectangle��69   	 � ��
 �	#FFF6FFCE6P   5�      P� 5�       � �� . 6;   P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   " ��6$   .�5�      �� 	 � ��
 5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ 	rectangle��6(   
�������
���   �6H   �� 5�      #��z��6/   ��. # z 6�   #��z��6�   $&�� Tổng Kết Điểm Các Đội��6  5�       5�      P� 5�       �@J�	IsFocused . 6;   P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . . �5�   "   �� $ 	rectangle��69   	 � ��
 �	#FF4EBEC36P   5�      P� 5�       � �� . . �5�   "   �� $ 	rectangle��69   	 � ��
 �	#FF7AEAF06P   5�      P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   " ��6"   .�5�      �� 	 � ��
 5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ 	rectangle��6(   ���	#FFF4F4F5
���   �6L   �� 5�      #��z��6/   ��. # z 6�   #��z��6�   $��	Đáp án��6  5�       5�      P� 5�       �@J�	IsFocused . 6;   P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . . �5�   "   �� $ 	rectangle��69   	 � ��
 �	#FF67D1BD6P   5�      P� 5�       � �� . . �5�   "   �� $ 	rectangle��69   	 � ��
 �	#FF63DACF6P   5�      P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   " ��6$   .�5�      �� 	 � ��
 5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ 	rectangle��6(   ���	#FFF4F4F5
���   �6L   �� 5�      #��z��6/   ��. # z 6�   #��z��6�   $	��←��6  5�       5�      P� 5�       �@J�	IsFocused . 6;   P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . . �5�   "   �� $ 	rectangle��69   	 � ��
 �	#FFECBE7B6P   5�      P� 5�       � �� . . �5�   "   �� $ 	rectangle��69   	 � ��
 �	#FFECC37B6P   5�      P� 5�       � {� .  . �5�   "   �� 	 � ��
 �	#FFE8B3B36?   5�      5     5     5     �� 5  
   " ��6#   .�5     �� 	 � ��
 5     �� 5     " ��6&   .R�5	     � .+�5
     �� $ 	rectangle��6(   ���	#FFF4F4F5
���   �6L   �� 5     #��z��6/   ��. # z 6�   #��z��6�   $	��→��6  5      5     P� 5      �@J�	IsFocused . 6;   P� 5      �@��IsDefaulted . 6=   P� 5      �@J�IsMouseOver . . �5  "   �� $ 	rectangle��69   	 � ��
 �	#FFECBE7B6P   5     P� 5      � �� . . �5  "   �� $ 	rectangle��69   	 � ��
 �	#FFECC37B6P   5     P� 5      � {� .  . �5  "   �� 	 � ��
 �	#FFE8B3B36?   5     5     5     5     �� 5  
   " ��6-   .�5     �� 	 � ��
 5      �� 5!     " ��6&   .R�5"     � .+�5#     �� $ 	rectangle��6(   ���	#FFF4F4F5
���   �6L   �� 5$     #��z��6/   ��. # z 6�   #��z��6�   $��Bắt Đầu��6  5%      5&     P� 5'      �@J�	IsFocused . 6;   P� 5(      �@��IsDefaulted . 6=   P� 5)      �@J�IsMouseOver . . �5*  "   �� $ 	rectangle��69   	 � ��
 �	#FF66C3BF6P   5+     P� 5,      � �� . . �5-  "   �� $ 	rectangle��69   	 � ��
 �	#FF89D5E66P   5.     P� 5/      � {� .  6;   51     53     54     �� 55  
   " ��60   .�56     �� 	 � ��
 57     �� 58     " ��6&   .R�59     � .+�5:     �� $ 	rectangle��6(   ���	#FFF4F4F5
���   �$
 Hand��6[   �� 5;     #��z��6/   ��. # z 6�   #��z��6�   $��Trình Chiếu��6  5<      5=     P� 5>      �@J�	IsFocused . 6;   P� 5?      �@��IsDefaulted . 6=   P� 5@      �@J�IsMouseOver . . �5A  "   �� $ 	rectangle��69   	 � ��
 �	#FFE482316P   5B     P� 5C      � �� . . �5D  "   �� $ 	rectangle��69   	 � ��
 �	#FFF094546P   5E     P� 5F      � {� .  6;   5H     5J     5K     5L     .��5M     � $��0q�6   .+�5N  
   � -   5         �Name$ gridSystemControl��5N     $��36��6*   $��0q�66   $	��Top=�6A   ���	#FFC3C3C3$y�Hidden=�6�   .+�5O     �� -   5         ��Name$ btnExit��5O     $��btnExit��6&   $��Right=�68   #���  6T   $��70��6v   $
��Bold"�6�   ���	#FFB2ACAC$��0q�6�   $��16(�6�   ���	#FF5B5B5B6�   �� 5P     -   5        $ btnMaximize��5P     $��btnMaximize��6*   $��Right=�6@   $��0,0,70,0q�6\   #���  6n   $��70��6�   $
��Bold"�6�   $��16(�6�   $��0q�6�   ���	#FF5B5B5B6�   �� 5Q     -   5        $ btnMinimize��5Q     $��btnMinimize��6*   $��Right=�6@   $��	0,0,140,0q�6\   #���  6o   $��70��6�   $��21.333(�6�   $
��Bold"�6�   $��0q�6�   ���	#FF5B5B5B���	#FFC3C3C36	  5R     � 5T  
   -   5        $ gridLogoNTT��5T     $��30��6$   $��0q�60   $��Bottom=�6;   
�������.+�5U     �� -   5         ��Name$ 
imaLogoNTT��5U     $��30��6(   $��Bottom=�64   $��1.png��6O   $��Center=�6^   $��482,0q�6{   5V     � 5W  
   -   5        $ 	gridTitle��5W     $	��105��6"   $��0q�6/   $	��Top=�6:   ��5X     �� 5Y      �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5Z     �  � Color$ White��6#    � Offset$ 0Q�61   � 5[     $ 	#FFF1F1F1��6#   $ 1Q�65   � 5\     $ White��6#   $ 0.673Q�61   � 5]     $ 	#FFFDFDFD��6#   $ 0.363Q�65   5^     .+�5`     � -	   5        $ gridLogo��5`     $
��Left=�6%   $��	40,10,0,0q�6@   $	��Top=�6S   .+�5a     �� -
   5        $ logoIT��5a     $
��Left=�6(   $��70,0,0,0q�6C   $��50��6U   $��	lgoIT.jpg��6`   $
��Fill=�6s   $	��Top=�6�   $��50��6�   �� 5b     -   5        $ logoUTE��5b     $��	-28,0,0,0q�6)   $��2.png��6<   $
��Fill=�6K   $	��Top=�6Z   $
��Left=�6r   $	��150��6�   $��80��6�   5c     � 5e     -   5        $ gridTextTitle��5e     $��
190,10,0,0q�6*   $
��Left=�6>   $	��Top=�6Y   .+�5f     �� -   5         ��Name$ lblUTE��5f     $G��ATRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT TP. HỒ CHÍ MINH��6(   $��0,10,0,0q�6b   $��Arial)�6t   $
��Left=�6�   $	��Top=�6�   $��0q�6�   �� 5g     -   5        $ lblIT��5g     $G��AKHOA CÔNG NGHỆ THÔNG TIN VÀ PHÒNG KHOA HỌC & CÔNG NGHỆ��6'   $��0,25,0,0q�6l   $��Arial)�6~   $	��Top=�6�   $
��Left=�6�   $��0q�6�   �� 5h     -   5        $ lblMIT��5h     $?��9CUỘC THI HỌC THUẬT MASTERING IT LẦN 12 NĂM 2017 ��6(   $��0,50,0,0q�6c   $��16(�6u   $��Arial)�6�   $
��Bold"�6�   $��0q�6�   $��Center=�6�   $	��Top=�6�   $
��Left=�6
  ��5i     �� 5j     $ 0.5,1&�6.   $ 0.5,0&�6?   .��5k     � $ Black��6+   $ 0Q�69   � 5l     $ 	#FF006683��6+   $ 0.911Q�6=   5m     5o     5p     � 5q     -   5        $ gridTime��5q     $��0,92,0,0q�6%   $��10��67   $��Bottom=�6C   .+�5r     � -   5         �Name$ prgTime��5r     
���   �$��0,0,0,-5q�6Y   $��0q�6k    � Maximum$
 1000Q�6   $��10��6�   ���	#FF6CBBBB��6B   Z� 6�   �� 5s     -   5         ��Name$ txbTime��5s     $��
0,-95,40,0q�6-   $
��Wrap=�6A   $	��</>��6U   $��72(�6f   $
��Bold"�6t   $��Calibri)�6�   $��Right=�6�   $	��Top=�6�   5t     5v     � 5w  
   -   5        $ gridGameInfo��5w     $
��Left=�6%   $��
0,110,0,22q�6@   $��295.5��6T   ��5x     �� 5y     $ 0.5,1&�6&   $ 0.5,0&�67   .��5z     � $ 	#FFCFCFCF��6#   $ 0Q�65   � 5{     $ 	#FFB9B9B9��6#   $ 1Q�65   � 5|     $ 	#FFB6B6B6��6#   $ 0.363Q�65   � 5}     $ 	#FEA0A0A0��6#   $ 0.795Q�65   5~     .+�5�     �� -   5         ��Name$ cmbLevel��5�     $	��Top=�6)   $��26��6A   $
��Bold"�6M   $��	13,15,0,0q�6_   $��0q�6�   $	��269��6�   $
��Left=�6�   $��0q�6�   $��Center=�6�   $��Center=�6�   $��14(�6  $
 Hand��6$  $��Calibri)�62  ���	#FFD6D6D6
���   ���6r   Z� 6q  �� 5�     -   5        $ cmbGame��5�     $��	13,47,0,0q�6(   $	��Top=�6;   $
��Bold"�6S   $��14(�6e   $��26��6s   $	��269��6   $
 Hand��6�   $��Center=�6�   $��Center=�6�   $��0q�6�   $��Calibri)�6�   $
��Left=�6   6  � 5�     -   5        $ gridTeamInfo��5�     $��13.5,90,13.5,50q�6)   .+�5�     �� $��0q�6   .+�5�     �� $��0q�6!   .+�5�     �� -   5        $ 	lblDoiSo1��5�      $�� ��63   ���	#FFE6E6E6$��40��6U   
���   �$��Center=�6t   $��0q�6�   $��26(�6�   $��Calibri)�6�   $��Center=�6�   $
��Bold"�6�   $��0q�6�   $��Center=�6  � 5�     $��0q�6   $	��Top=�6*   .+�5�     �� -   5         ��Name$ txtScoreDoiSo1��5�  &   $��40��6>   $
��23,0q�6J     �� TextWrapping$
  Wrap=�6X   $��0q�6l   $��24(�6�   $��Center=�6�   $��Center=�6�   $��Calibri)�6�   $
��Bold"�6�   ! �� 	MaxLength$! 4��6�   
�������6=  �� 5�     -   5        $ btnPlusScoreDoiSo1��5�  %   $��Button��6A   $��40��6R   $��1,1,0,1q�6^   #���  6o   $��0q�6�   $��Calibri)�6�   $
 Hand��6�   $��23��6�   $��Right=�6�   $��0q�6�   �� 5�     -   5        $ btnMinusScoreDoiSo1��5�  %   $��Button��6B   $��40��6S   $��1q�6_   #���  6j   $��0q�6�   $��Calibri)�6�   $
 Hand��6�   $
��Left=�6�   $��23��6�   ���	#FFF0F0F0$��0q�6  5�     5�     �� 5�     $��0,10,0,0q�6!   .+�5�     �� -   5        $ 	lblDoiSo2��5�      $�� ��63   ���	#FFE6E6E6$��40��6U   
���   �$��Center=�6t   $��0q�6�   $��26(�6�   $��Calibri)�6�   $��Center=�6�   $
��Bold"�6�   $��0q�6�   $��Center=�6  � 5�     $��0q�6   $	��Top=�6*   .+�5�     �� -   5        $ txtScoreDoiSo2��5�  &   $��40��6>   $
��23,0q�6J   $
  Wrap=�6X   $��0q�6l   $��24(�6�   $��Center=�6�   $��Center=�6�   $��Calibri)�6�   $
��Bold"�6�   $! 4��6�   
�������6=  �� 5�     -   5        $ btnPlusScoreDoiSo2��5�  %   $��Button��6A   $��40��6R   $��1,1,0,1q�6^   #���  6o   $	��Top=�6�   $��0q�6�   $��Calibri)�6�   $
 Hand��6�   $��23��6�   $��Right=�6�   �� 5�     -   5        $ btnMinusScoreDoiSo2��5�  %   $��Button��6B   $��40��6S   $��1q�6_   #���  6j   $��0q�6�   $��Calibri)�6�   $
 Hand��6�   $
��Left=�6�   $��23��6�   ���	#FFF0F0F06�   5�     5�     �� 5�     $��0,10,0,0q�6!   .+�5�     �� -   5        $ 	lblDoiSo3��5�      $�� ��63   ���	#FFE6E6E6$��40��6U   
���   �$��Center=�6t   $��0q�6�   $��26(�6�   $��Calibri)�6�   $��Center=�6�   $
��Bold"�6�   $��0q�6�   $��Center=�6  � 5�     $��0q�6   $	��Top=�6*   .+�5�     �� -    5        $ txtScoreDoiSo3��5�  &   $��40��6>   $
��23,0q�6J   $
  Wrap=�6X   $��0q�6l   $��24(�6�   $��Center=�6�   $��Center=�6�   $��Calibri)�6�   $
��Bold"�6�   $! 4��6�   
�������6=  �� 5�     -!   5        $ btnPlusScoreDoiSo3��5�  %   $��Button��6A   $��40��6R   $��1,1,0,1q�6^   #���  6o   $��0q�6�   $��Calibri)�6�   $
 Hand��6�   $��23��6�   $��Right=�6�   �� 5�     -"   5        $ btnMinusScoreDoiSo3��5�  %   $��Button��6B   $��40��6S   $��1,1,3,1q�6_   #���  6p   $��0q�6�   $��Calibri)�6�   $
 Hand��6�   $
��Left=�6�   $��23��6�   ���	#FFF0F0F06�   5�     5�     �� 5�     $��0,10,0,0q�6!   .+�5�     �� -#   5        $ 	lblDoiSo4��5�      $�� ��63   ���	#FFE6E6E6$��40��6U   
���   �$��Center=�6t   $��0q�6�   $��26(�6�   $��Calibri)�6�   $��Center=�6�   $
��Bold"�6�   $��0q�6�   $��Center=�6  � 5�     $��0q�6   $	��Top=�6*   .+�5�     �� -$   5        $ txtScoreDoiSo4��5�  &   $��40��6>   $
��23,0q�6J   $
  Wrap=�6X   $��0q�6l   $��24(�6�   $��Center=�6�   $��Center=�6�   $��Calibri)�6�   $
��Bold"�6�   $! 4��6�   
�������6=  �� 5�     -%   5        $ btnPlusScoreDoiSo4��5�  %   $��Button��6A   $��40��6R   $��1,1,0,1q�6^   #���  6o   $��0q�6�   $��Calibri)�6�   $
 Hand��6�   $��23��6�   $��Right=�6�   �� 5�     -&   5        $ btnMinusScoreDoiSo4��5�  %   $��Button��6B   $��40��6S   $��1q�6_   #���  6j   $��0q�6�   $��Calibri)�6�   $
 Hand��6�   $
��Left=�6�   $��23��6�   ���	#FFF0F0F06�   5�     5�     �� 5�     $��0,10,0,0q�6!   .+�5�     �� -'   5        $ 	lblDoiSo5��5�      $�� ��63   ���	#FFE6E6E6$��40��6U   
���   �$��Center=�6t   $��0q�6�   $��26(�6�   $��Calibri)�6�   $��Center=�6�   $
��Bold"�6�   $��0q�6�   $��Center=�6  � 5�     $��0q�6   $	��Top=�6*   .+�5�     �� -(   5        $ txtScoreDoiSo5��5�  &   $��40��6>   $
��23,0q�6J   $
  Wrap=�6X   $��0q�6l   $��24(�6�   $��Center=�6�   $��Center=�6�   $��Calibri)�6�   $
��Bold"�6�   $! 4��6�   
�������6=  �� 5�     -)   5        $ btnPlusScoreDoiSo5��5�  %   $��Button��6A   $��40��6R   $��1,1,0,1q�6^   #���  6o   $��0q�6�   $��Calibri)�6�   $
 Hand��6�   $��23��6�   $��Right=�6�   �� 5�     -*   5        $ btnMinusScoreDoiSo5��5�  %   $��Button��6B   $��40��6S   $��1q�6_   #���  6j   $��0q�6�   $��Calibri)�6�   $
 Hand��6�   $
��Left=�6�   $��23��6�   ���	#FFF0F0F06�   5�     5�     5�     5�     �� 5�     -+   5        $ 
btnSummary��5�     $��Button��6)   $��26��6:   $��
13,0,13,10q�6F   #���  6Z   $��Bottom=�6�   $��0q�6�   $
��Bold"�6�   $
 Hand��6�   $��Calibri)�6�   $��14(�6�   6�   5�     � 5�  
   -,   5        $ gridGameMain��5�     $��295,110,0,22q�6%   
�������.+�5�     �� --   5        " ��Name$" stpGamePlay��5�     $��0q�6.   .+�5�     �� -.   5        $ txbTenCauHoi��5�     $
��Wrap=�62   $��24(�6v   $
��Bold"�6�   $��Calibri)�6�   $��	Underline{�6�   # �� Padding$# 
30,0,30,10q�6�   �� 5�     -/   5        $ txbNoiDungCauHoi��5�     $
��Wrap=�66   $
��Bold"�6J   $��48(�6\   $# 
30,0,30,30q�6�   $��Calibri)�6�   A� 5�     -0   5        $ A�Name$$ uniformGridLuaChon��5�     $��0q�6q   .+�5�     � -1   5        $ gridA��5�     $��0q�6*   .+�5�     �� -2   5        $
 txbA��5�  $   $��0q�62   $
��Wrap=�6=   $��48(�6Q   $��Calibri)�6_   $
��Bold"�6t   $
��Left=�6�   $# 30,0,0,0q�6�   $	��Top=�6�   �� 5�     -3   5        $ txbLuaChonA��5�  $   $
��Wrap=�69   $��48(�6M   
���   �$# 0q�6n   $��	80,0,0,20q�6z   $
��Left=�6�   $��Calibri)�6�   5�     � 5�     -4   5        $ gridB��5�     .+�5�     �� -5   5        $
 txbB��5�  $   $��0q�62   $
��Wrap=�6=   $��48(�6Q   $��Calibri)�6_   $
��Bold"�6t   $
��Left=�6�   $# 30,0,0,0q�6�   $	��Top=�6�   �� 5�     -6   5        $ txbLuaChonB��5�  $   $
��Wrap=�69   $��48(�6M   $# 0,0,0,20q�6[   $��80,0,0,0q�6n   $
��Left=�6�   $��Calibri)�6�   5�     � 5�     -7   5        $ gridC��5�     $��0q�6*   .+�5�     �� -8   5        $
 txbC��5�  $   $��0q�62   $
��Wrap=�6=   $��48(�6Q   $��Calibri)�6_   $
��Bold"�6t   $
��Left=�6�   $# 30,0,0,0q�6�   $	��Top=�6�   �� 5�     -9   5        $ txbLuaChonC��5�  $   $
��Wrap=�69   $��48(�6M   $# 0q�6[   $��80,0,0,-0.001q�6g   $
��Left=�6~   $��Calibri)�6�   5�     � 5�     -:   5        $ gridD��5�     .+�5�     �� -;   5        $
 txbD��5�  $   $��0q�62   $
��Wrap=�6=   $��48(�6Q   $��Calibri)�6_   $
��Bold"�6t   $
��Left=�6�   $# 30,0,0,0q�6�   $	��Top=�6�   �� 5�     -<   5        $ txbLuaChonD��5�  $   $
��Wrap=�69   $��48(�6M   $# 0q�6[   $��80,0,0,0q�6g   $
��Left=�6y   $��Calibri)�6�   5�     5�     5�     � 5�     -=   5        $ gridGameButton��5�     $��40��6+   $��Bottom=�67   .+�5�     �� ->   5        $ 	btnAnswer��5�     $��Button��6,   $��Right=�6=   $��26��6Y   $��0,0,20,0q�6e   #��� 	 6w   $��Center=�6�   $	��100��6�   $
 Hand��6�   $��Calibri)�6�   $��14(�6�   $
��Bold"�6�   6  �� 5�     -?   5        $ btnPreviewQuestion��5�     $��Button��65   $
��Left=�6F   $��26��6a   $��20,0,0,0q�6m   #��� 
 6   $��Center=�6�   $��50��6�   $��22(�6�   $
��Bold"�6�   $��Calibri)�6�   $
 Hand��6   $��Center=�6  62  �� 5�     -@   5        $ btnNextQuestion��5�     $��Button��62   $
��Left=�6C   $��26��6^   $��80,0,0,0q�6j   #���  6|   $��Center=�6�   $��50��6�   $��Calibri)�6�   $
��Bold"�6�   $��22(�6�   $
 Hand��6�   6
  F� 5�     -A   5        % F�Name$% lineGame��5�     ���� 6n 3����+ 3�	���	#FFBDBDBD$��1��6X   $��0q�6c   & �� Stretch$
& Fill=�6n   
���   �$	��Top=�6�   �� 5�     -B   5        $ btnStartTime��5�     $��Button��6/   $
��Left=�6@   $��26��6[   $��	170,0,0,0q�6g   #���  6z   $��Center=�6�   $	��100��6�   $
��Bold"�6�   $��14(�6�   $��Calibri)�6�   $
 Hand��6  6  �� 5�     -C   5        $ btnShowQuestion��5�     $��Button��62   $
��Left=�6C   $��26��6^   $��	280,0,0,0q�6j   #���  6}   $��Center=�6�   $	��100��6�   
���   �$��14(�6�   $
��Bold"�6�   $��Calibri)�6
  $
 Hand��6  5�     5�     5�     5�     