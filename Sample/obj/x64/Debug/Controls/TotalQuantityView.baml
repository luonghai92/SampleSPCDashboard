   M S B A M L   `   `   `  ����A  =Sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Sample.ControlsSample.Controls  5      '    !Sample.Controls.TotalQuantityView   5      ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Sample.Controls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5      � .+�5   
   �� ���#FFFFFF  �� CornerRadius$  10��6&    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 9Q�6#      Color$ 	LightGray��63   ._�5      �  � RowDefinitions 5      �� 5      $��50 �6$   �� 5      $��40 �6$   �� 5      $��* �6$   .+�5      �� $��	10,0,10,0q�5      $��Center=�5      $��20(�5      $
��Bold"�5      $��	Underline{�5      $%��Actual Quantity / Plan Quantity��5      � 5      $��1��5      $
��auto��5       $��	50,0,50,0q�5!      $��20��5"      
��� ��� � Value$ 80Q�5$      � 5%      $��2��6    � ColumnDefinitions 5&      �� 5'      �� 5(      .+�5*      �� $
��auto��5+      $	��130��5,      $��	50,0,50,0q�5-      
�������
�������$��2q�50      $  20��51      ._�52      �� .+�53      �� $��20��6(   �� 54      $��Center=�55   !   $��
Product OK��56   !   $��20(�57   !   $
��Bold"�58   !   ���	#FF13B31359   !   �� 5:      $��20��6(   �� 5;      $��Center=�5<   !   $��0 PCS��5=   !   $��20(�5>   !   $
��Bold"�5?   !   ���	#FF13B3135@   !   5A      5B      �� 5C      $
��auto��5D      $	��130��5E      $��	50,0,50,0q�5F      
�������
�������$��2q�5I      $��1��5J      $  20��5K      ._�5L      �� .+�5M      �� $��20��6(   �� 5N      $��Center=�5O   !   $��
Product NG��5P   !   $��20(�5Q   !   $
��Bold"�5R   !   
���  ��5S   !   �� 5T      $��20��6(   �� 5U      $��Center=�5V   !   $��0 PCS��5W   !   $��20(�5X   !   $
��Bold"�5Y   !   
���  ��5Z   !   5[      5\      5]      5^      5_      5`      5a      