   M S B A M L   `   `   `  ����A  =Sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Sample.ControlsSample.Controls  5      N JCircularProgressBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:CircularProgressBar;assembly=CircularProgressBarCircularProgressBar 5      !    Sample.Controls.StationView   5      ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Sample.Controls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Mcp>clr-namespace:CircularProgressBar;assembly=CircularProgressBar     5        � 	Resources  5
         RoundedRectangleStyle �� 
TargetType �� Property �� Value��%A  &	        �� 5   
   " ��6.   .�5      ��  �@J�SnapsToDevicePixels . 64   �� 5       � ��$ 1��60   �� 5       � �� �	#FF0000006'   �� 5       � �� �	#FFFFFFFF6%   �� 5       �@�UseLayoutRounding . 62   �� 5       �@��Stretch$
 Fill=�6(   5      5      .��5      � .+�5   
   ��  �� Padding$ 0q�5      ���#FFFFFF$��1,1,1,1q�5       �� CornerRadius$ 10, 10, 0, 0��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 9Q�6#      Color$ 	LightGray��63   ._�5       � $��0,0,0,0q�6   	 � RowDefinitions	 5!      �� 5"      $��50 �6$   �� 5#      
 � ColumnDefinitions
 5%      �� 5&      $��* �6'   �� 5'      $��* �6'   �� 5(      $��* �6'   �� 5)      $��* �6'   .+�5+      �� $��0,0,0,0q�5,      $ 5q�5-      ���	#FF2727A0
����  �$��1,1,1,1q�50      $ 	10 0 10 0��51      ._�52      �� -   5        $��lbStationName��53      $��Center=�54      $��Center=�55      $��22(�57      $
��Bold"�58      
���������56      �� *Text+59      5:      ]� 5;      $��1��6   .+�5<      �� $��20��5=      $��20��5>      $��10,0,0,0q�5?      $
��Left=�5@      $ 3��5B      ��5A      �� *StatusColor+5B      �� 5C      $��Center=�5D      $��Running��5E      $��20(�5F      $��Italic$�5G      $
��Bold"�5H      5I      � 5K      -   5         �Name$ progressBar��5L      $��2��5M      $��2��5N      $	��350��5O      $��30��5P      $��Center=�5Q       � Maximum$	 100Q�5R       � Minimum$ 0Q�5S       � Value 5T      �� *progressValue+��5U      �� 5V       �� 
TargetType" �6*   .R�5W      � .+�5X   "   ��  ��Name$ 
PART_Track��6,   #��z��6@   �� 5Y   "   $ PART_Indicator��5Z   %   $
��Left=�5[   %   #��z��5\   %   �� 5]   "    ��Name$ progressText��5^   %   $��Center=�5_   %   $��Center=�5`   %   
���   ���5b   %   �� *Value+ �� RelativeSource ��  �� AncestorType$ ProgressBarL� �� StringFormat$
 {0}%��5c      5d      5f      �� 5g      $��1��6   4  .CircularProgressBar.CircularProgressBarControl  5h      $��1��60   $	��100��6=   $	��100��6I      Value$ 75Q�6V   �� 5j      $��1��5k      $��1��5l      $��4q�5m      
���   �$��1q�5o      $ 10��5p      ._�5q      �� .+�5r      �� $��30��5s      ���	#FF2727A0$ 	10,10,0,0��5u      ._�5v      ]� .+�5w   "   �� $
��Left=�5x   %   $��Center=�5y   %   $��Availability��5z   %   $��15(�5{   %   
�������5|   %   �� 5}   "   $��Right=�5~   %   $��Center=�5   %   $��15(�5�   %   
���������5�   %   �� *Aavaibility+$
 {0}%��5�   %   5�      5�      �� 5�      $��10��6$   ]� 5�      .+�5�      �� $
��Left=�5�   !   $��Center=�5�   !   $��Downtime��5�   !   $��15(�5�   !   
���   �5�   !   �� 5�      -   5        $��Downtime��5�   !   $��Right=�5�   !   $��Center=�5�   !   $��15(�5�   !   
��� � ���5�   !   �� *
DownTime+$ {0} h��5�   !   5�      �� 5�      $��10��6$   ]� 5�      .+�5�      �� $
��Left=�5�   !   $��Center=�5�   !   $
��MTTR��5�   !   $��15(�5�   !   
���   �5�   !   �� 5�      -   5        $
��MTTR��5�   !   $��Right=�5�   !   $��Center=�5�   !   $��15(�5�   !   
��� � ���5�   !   �� *Total+$ {0} %��5�   !   5�      �� 5�      $��10��6$   ]� 5�      .+�5�      �� $
��Left=�5�   !   $��Center=�5�   !   $
��MTBF��5�   !   $��15(�5�   !   
���   �5�   !   �� 5�      -   5        $
��MTBF��5�   !   $��Right=�5�   !   $��Center=�5�   !   $��15(�5�   !   
��� � ���5�   !   �� *Total+$ {0} %��5�   !   5�      5�      5�      �� 5�      $��1��5�      $��2��5�      $��4q�5�      
���   �$��1q�5�      $ 10��5�      ._�5�      �� .+�5�      �� $��30��5�      ���	#FF2727A0$ 	10,10,0,0��5�      ._�5�      ]� .+�5�   "   �� $
��Left=�5�   %   $��Center=�5�   %   $��Performance��5�   %   $��15(�5�   %   
�������5�   %   �� 5�   "   -   5        $��Performance��5�   %   $��Right=�5�   %   $��Center=�5�   %   $��15(�5�   %   
���������5�   %   �� *Performance+$
 {0}%��5�   %   5�      5�      �� 5�      $��10��6$   ]� 5�      .+�5�      �� $
��Left=�5�   !   $��Center=�5�   !   $��Ideal Prod:��5�   !   $��15(�5�   !   
���   �5�   !   �� 5�      -   5        $��	IdealProd��5�   !   $��Right=�5�   !   $��Center=�5�   !   $��15(�5�   !   
��� � ���5�   !   �� *	IdealProd+$ 	{0} pcs/h��5�   !   5�      �� 5�      $��10��6$   ]� 5�      .+�5�      �� $
��Left=�5�   !   $��Center=�5�   !   $��
Gross Prod��5�   !   $��15(�5�   !   
���   �5�   !   �� 5�      -   5        $��	GrossProd��5�   !   $��Right=�5�   !   $��Center=�5�   !   $��15(�5�   !   
��� � ���5�   !   �� *	GrossProd+$ 	{0} pcs/h��5�   !   5�      �� 5�      $��10��6$   ]� 5�      .+�5�      �� $
��Left=�5�   !   $��Center=�5�   !   $��Losses��5�   !   $��15(�5�   !   
���   �5�   !   �� 5�      -	   5        $��Losses��5  !   $��Right=�5�   !   $��Center=�5�   !   $��15(�5  !   
��� � ���5   !   �� *Losses+$ 	{0} pcs/h��5  !   5     5     5     �� 5     $��1��5     $��3��5	     $��4q�5
     
���   �$��1q�5     $ 10��5     ._�5     �� .+�5     �� $��30��5     ���	#FF2727A0$ 	10,10,0,0��5     ._�5     ]� .+�5  "   �� $
��Left=�5  %   $��Center=�5  %   $��Quality��5  %   $��15(�5  %   
�������5  %   �� 5  "   $��70��5  %   $��Center=�5  %   $��Center=�5  %   $��15(�5  %   
���������5  %   �� *QuantityNGPercent+$
 {0}%��5   %   �� 5!  "   $��Right=�5"  %   $��Center=�5#  %   $��15(�5%  %   
���������5$  %   �� *QuantityPercent+$
 {0}%��5&  %   5'     5(     �� 5)     $��10��6$   ]� 5*     .+�5+     �� $
��Left=�5,  !   $��Center=�5-  !   $��Total:��5.  !   $��15(�5/  !   
���   �50  !   �� 51     -
   5        $��Total��56  !   $��Right=�52  !   $��Center=�53  !   $��15(�55  !   
��� � ���54  !   �� *Total+$ {0} pcs��57  !   58     �� 59     $��10��6$   ]� 5:     .+�5;     �� $
��Left=�5<  !   $��Center=�5=  !   $	��OK:��5>  !   $��15(�5?  !   
���   �5@  !   �� 5A     -   5        $��NumOK��5E  !   $��Right=�5B  !   $��Center=�5C  !   $��15(�5F  !   
��� � ���5D  !   �� *Total+$ {0} pcs��5G  !   5H     �� 5I     $��10��6$   ]� 5J     .+�5K     �� $
��Left=�5L  !   $��Center=�5M  !   $	��NG:��5N  !   $��15(�5O  !   
���   �5P  !   �� 5Q     -   5        $��NumNG��5U  !   $��Right=�5R  !   $��Center=�5S  !   $��15(�5V  !   
��� � ���5T  !   �� *Total+$ {0} pcs��5W  !   5X     �� 5Y     $��10��6$   ]� 5Z     .+�5[     �� $
��Left=�5\  !   $��Center=�5]  !   $��NG Setup��5^  !   $��15(�5_  !   
���   �5`  !   �� 5a     -   5        $��
NumNGSetup��5e  !   $��Right=�5b  !   $��Center=�5c  !   $��15(�5f  !   
��� � ���5d  !   �� *Total+$ {0} pcs��5g  !   5h     5i     5j     5k     5l     5n     5o     