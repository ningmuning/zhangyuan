   M S B A M L   `   `   `  ����
  subway"    Home.Customer.CustomerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  CustomerWindow��5   	   $	��750��5   	   $
��1000��6    � WindowState$ 	Maximized=�6#    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5	      $ /DictionaryCustomer.xaml?�6%   %    5      .��5      � ���#1B4F93 � ColumnDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��82* �6   �� 5      $	��119 �6    � RowDefinitions 5   
   �� 5      $	��59* �6   �� 5      $
��591* �6   �� 5      $��69 �6   .+�5   
   � $	��Top=�6   $��Stretch=�6'   $��2��6E   $��59��6Y   .+�5      �� 
�������$��25(�6'   $
��Left=�65   $��郑州地铁��5      $	��Top=�6#   $��20,0,0,0q�6;   �� 5      
��� ���$��10(�6(   $
��Left=�66   $��ZHENGZHOU METRO��5      $��Bottom=�6.   $��17,0,0,0q�6I   �� 5      -   5        $��label3��5      
�������$��40(�65   $��Center=�6C      port#���   5       J� RenderTransformOrigin$ 
3.256,0.38&�65   $��366,-4,131,4q�6X   $	��376��6n   �� 5       -   5         ��Name$ label��5       $��25(�6#   $��Right=�61   $��
768,10,0,0q�6M   $	��Top=�6a   5!      �� 5"   
   -   5        $��2��5"      $��0��6!   ��5#      �� 5$      	 �� ImageSource$$	 /subway;component/images/a.PNG��6   5&      � 5'   
   $��2��6   $��0��6   .+�5(      �� -   5        $��Button1��5(      $��Right=�6$   
��� ���$��797,10,10,0q�5)      $	��Top=�6*   $��55��5*      $��40��6    $ 2.569,1.116&�6,   .��5+      �� .+�5,      �� $��/images/a.png��6   $��50��63   $��40��6>   5-      5.      5/      �� 50   
   $��1��6   $��0��6"    51        storyBorard1
 g� Duration W� From �� 
TargetName �� TargetProperty g� RepeatBehavior g� AutoReverse �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value :� RoutedEvent ��Name��%+  &	       '�� �     7  �� 52      $
 0:0:3D�62   .��53      W� $ 50X�6&   $
 0:0:1D�61   $ 	rectangle��6B   $ (Rectangle.Width)�6d   $ 1��6�    . 6�   54      �� 55      " ��6   .�56      ��  � ��$
 Left=�6<   �� 57       � ��$ 14,5,0,0q�6/   �� 58       � ��$	 115��6.   �� 59       � ��$ 40��6/   �� 5:       � ��$ 25(�61   �� 5;       � ��
 ��ح�63   -   5        �� 5=       � �� 5>      �� 5?      " ��6.   .R�5@   "   � .+�5A   &   �� $ 	rectangle��60   $	��115��6C   $��40��6O   $��1��6[   #��z��6o   #��z��6�   $��Center=�6�   $��Center=�6�   �� 5B   &   #��z��67   $��Center=�6[   $��Center=�6x   5C   #    5D   "   P� 5E   &    �@J�IsMouseOver . . �5F   *   ��  � ��
 �  ��6G   5G   '   P� 5H   &    � �� . . �5I   *   ��  � ��
 � ���6G   5J   '   :� 5K   &   $ ButtonBase.Click��63   [�5L   *   �� 5M   .   $ BeginStoryboard��6>   8��  6U   5O   '   5Q      5S      5T      5U      .+�5V      �� -   5        $��label2��5V        qxuanze#���  6"   $��18(�6F   �� 5W      -   5        $��b1��5W        one#���  6   �� 5X      -   5        $��b2��5X        two#���  6   �� 5Y      -	   5        $��b3��5Y       	 three#���  6   �� 5Z      -
   5        $��b4��5Z        four#���  6   �� 5[      -   5        $��b5��5[        five#���  6   �� 5\      -   5        $��b6��5\        six#���  6   �� 5]      -   5        $��b7��5]       		 seven#��� 	 6   �� 5^      -   5        $��b8��5^       	
 eight#��� 
 6   �� 5_      -   5        $��b9��5_        nine#���  6   �� 5`      -   5        $	��b10��5`        ten#���  6    �� 5a      -   5        $��ylabel��5a        yixuanze#���  6"   $��27(�6G   $
��Left=�6U   $	��Top=�6p   
���   �6�   �� 5b      -   5        $��textbox1��5b        zero#���  6&   $��30(�6D   $��Normal$�6R   $	��120��6e   $��68��6q   $��Center=�6}   $��Center=�6�   $��8,0,7.579,0q�6�   5c      � 5d   
   $��0��6   $��2��6   .+�5e      �� -   5        $��ButtonOK��5e        queding#���  6%   $��Center=�6`   $��Right=�6{   $��46��6�   $	��116��6�   ���#F1AF00$��25(�6�    �� 	IsDefault . $��0,12,9.579,11.053q�6�   5f      � 5g   
   $��1��6   $��1��6    5h      �� 5i      $	��17* �6    �� 5j      $
��145* �6    .+�5l      � .+�5m      �� 
�������$��3q�6-   �� 5n      -   5        $��label1��5n      #���  6&   
�������$��20(�6]   $
��Left=�5o      $��	16,10,0,0q�6/   $	��Top=�6B   $��34��6Z   $	��189��6f   �� 5p      -   5        $��buttonG��5p       
 zongtu#���  5q      $��30��6<   $	��Top=�6H   $��80��5r      
�������$
��Left=�5s      $��
257,14,0,0q�61   $��18(�5t      ���	#FFF177776>   �� 5u      -   5        $��buttonO��5u        	yihaoxian#���  5v      $��30��6?   $	��Top=�6K   $��80��5w      
�������$
��Left=�5x      $��
367,14,0,0q�61   $��18(�5y      ���	#FFB60F0F6>   �� 5z      -   5        $��	comboBox1��5z       �� SelectedIndex$ 0��6,   $��90��6>   $��30��6I   $��20(�6U   $��628,9,10,23q�6d   .@�5{      ��   danpiao#���  6#   �� 5|        
doublepiao#���  6#   5}      5~      � 5      $��1��6   $��1��6#    5�      �� 5�      $
��161* �6'   .+�5�       � -   5        $��frame2��5�        � NavigationUIVisibility$ Hidden=�6&   $��2��6F   ��5�      �� 5�      $&	  /subway;component/images/map.jpg��6%   5�      �� 5�      -   5         ��Name$ button��5�       	 yuyan#���  6)   $��Bottom=�6K   $��25(�6g   $��320,530,318,-50q�6u   $	��100��6�   ��5�      �� 5�       � MappingMode$ RelativeToBoundingBox=�6.    �� EndPoint$ 0.5,1&�6R     �� 
StartPoint$  0.5,0&�6c   .��5�      � ! � Color$	! Red��6+   " � Offset$	" 0.2Q�67   � 5�      $! Yellow��6+   $" 1Q�6:   5�      5�      5�      5�      � 5�   
   $��2��6   $��1��6   
������� 5�      �� 5�      $��62 �6    �� 5�      $��66 �6    �� 5�      $	��120 �6    .+�5�      � $��0��6   .+�5�      �� -   5        $��ylabelm��5�        	yixuanzem#���  6'   $��Normal$�6M   
���  ��$��18(�6q   $
��Left=�6   $	��Top=�6�   �� 5�      -   5        $��
textblock2��5�        zeroyuan#���  6.   
���  ��$��Right=�6a   $��Bottom=�6}   $��20(�6�   $��0,0,19,0q�6�   5�      � 5�      $��1��6   .+�5�      �� -   5        $��labelm��5�       
 xuanze#���  6&   $��25(�6I   $��Center=�6W   $	��Top=�6t   5�      �� 5�      $��2��6   $��
0,0,0,-348q�6&    5�      ��%.  &	       '�� �     7  �� 5�      $
 0:0:3D�66   .��5�      W� $ 50X�6*   $
 0:0:1D�65   $ 	rectangle��6F   $ (Rectangle.Width)�6h   $ 1��6�    . 6�   5�      �� 5�      " ��6   .�5�      ��  � ��$ Center=�6@   �� 5�       � ��$ 	14,5,5,15q�63   �� 5�       � ��$	 115��62   �� 5�       � ��$ 40��63   �� 5�       � ��$ 25(�65   �� 5�       � ��
 ��ح�67   -   5        �� 5�       � �� 5�      �� 5�   "   " ��62   .R�5�   &   � .+�5�   *   �� $ 	rectangle��64   $	��115��6G   $��40��6S   $��1��6_   #��z��6s   #��z��6�   $��Center=�6�   $��Center=�6�   �� 5�   *   #��z��6;   $��Center=�6_   $��Center=�6|   5�   '    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  � ��
 �  ��6K   5�   +   P� 5�   *    � �� . . �5�   .   ��  � ��
 � ���6K   5�   +   :� 5�   *   $ ButtonBase.Click��67   [�5�   .   �� 5�   2   $ BeginStoryboard��6B   8��  6Y   5�   +   5�   #   5�      5�      5�      .+�5�      �� -   5        $��m1��5�        twoyuan#���  6#   $��0,5,-2.263,15q�6G   $	��121��6^   �� 5�      -   5        $��m2��5�        	threeyuan#���  6#   $��0,5,-0.263,15q�6I   $	��119��6`   �� 5�      -    5        $��m3��5�        fouryuan#���  6#   $��0,5,-2.263,15q�6H   $	��121��6_   �� 5�      -!   5        $��m4��5�        fiveyuan#���  6#   $��0,5,-2.263,15q�6H   $	��121��6_   �� 5�      -"   5        $��m5��5�        sixyuan#���  6#   $��0,5,-2.263,15q�6G   $	��121��6^   5�      5�      �� 5�   
   -#   5        $��Button_cancel��5�       
 quxiao#���  6&   
���  ��$��25(�6Z   $��50��6h   $��2��6t   $��2��6�   # �� IsCancel# . $��10.053,9.368,-0.316,9.684q�6�   5�      5�      