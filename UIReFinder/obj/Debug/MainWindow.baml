   M S B A M L   `   `   `  ����C  ?ReFinder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:UIReFinder
UIReFinder  5   	   9!clr-namespace:UIReFinder.ControlsUIReFinder.Controls  60       UIReFinder.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:UIReFinder     5   	   6Controls!clr-namespace:UIReFinder.Controls     60      WindowStyle#���   5        � Title$  ReFinder��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   � $	��Top=�6   $��30��6'   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��30��6N   $	��Top=�6Z   .+�5      !   UIReFinder.Controls.LBorder  -   5          Name$
 bmin��5   #      Content$	 ��61     DefButtonStyleBorderHover#��[ 6E     SegoeMDL2StyleLabelText   
LabelStyle# [ 6x   $��48��6�     5      -   5        $
 bmax��5   #   $	 ��61   #��[ 6E   # [ 6x   $��48��6�     5      -   5        $ bclose��5   #   $	 ��63     CloseButtonStyleBorderHover#��[ 6G   # [ 6|   $��48��6�   5      �� 5      -   5         ��Name$ TitleWindow��5      
�������$��Center=�6<   $��14(�6^   $
��Left=�6l   $	��Top=�6�   6�   5      � 5   
   $��0,35,0,0q�6   ���#191919.+�5      � $	��Top=�6    � ColumnDefinitions 5      �� 5      $
��257* �6'   �� 5      $
��355* �6'   �� 5      $	��80* �6'   .+�5      �� ���	#99FFFFFF$��1q�61    �� CornerRadius$ 0��6E   $��30��6V   $��Center=�6b   ._�5      "   UIReFinder.Controls.CTextBox  -   5          Name$
 path��5   (   $�� ��66   5      �� 5      ���	#99FFFFFF$��1q�61   $ 0��6E   $��30��6V   $��Center=�6b   $��1��6~   ._�5        -   5        $ regex��5   (   $��[0-9]+��67   5         5!      !   UIReFinder.Controls.LBorder!	   PreviewMouseLeftButtonDown$	 button_find��6   $��2��6#   $
 Find��63   
   FontBush

 �����  StyleBorderHover#���  6T   6�   5"      � 5#      $��0,35,0,0q�6   .+�5$      �� -   5         ��Name$ listbox_items��5$        _ListBoxItemStyle_hover#���  61   ��6p   Z� ��6�   Z� ��6�   Z� 5&      5'      5(      �� 5)   
   -   5         ��Name$ resizeborder��5)      $��20��6'   $��20��62   $��Right=�6>   $��Bottom=�6Z   ���	#02FFFFFF J� Opacity$	 0.1Q�6�   6�   5+      5,      