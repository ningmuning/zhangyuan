   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	   A =subway, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:subway.MyManagesubway.MyManage 5   	   "   subway.MyManage.ManagerLogin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Twinform@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   /localclr-namespace:subway.MyManage     5   	     � Title$  	管理员��5	   	   $	��750��6   $
��1000��6"    � WindowState$ 	Maximized=�6/   
������� � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /DictionaryAdmin.xaml?�6%   %    5      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFF9FDFD��6    � Offset$ 0Q�61   � 5      $ 	#FFA8E6C4��6   $ 1Q�61   � 5      $ 	#FFB5EEEE��6   $ 0.502Q�61   5      .+�5   
   �� -   5        	 ��Name$	 location��5      
�������$��50(�65   $��Center=�6C      port#���   5      $��388,10,120,640q�65   $	��484��6M   $��Center=�6Y   $��69��6t   �� 5   
   -   5        $	 
label_Copy��5        mima#���  6$   $
��Left=�6E   $��25(�6`   $��181,347,0,0q�6n   $	��Top=�6�   $	��150��6�   �� 5   
   -   5        
 ��Name$
 textBox��5      $��54��6#   $��351,171,137,0q�6/    �� TextWrapping$
 Wrap=�6F   $	��Top=�6Z   $��25(�6r   G� 5   
   -   5         G�Name$ passwordBox��5       G� PasswordChar$ *��6+   $��353,335,137,0q�6<   $	��Top=�6S   $��55��6k   $��25(�6w    G� Password$  ��6�   �� 5   
   -   5        $	 label_Copy1��5       	 admin#���  6%   $
��Left=�6G   $��180,180,0,450q�6b   $	��138��6y   $��25(�6�   �� 5   
   -   5         ��Name$ button��5      $��20(�6!    
 denglu#���  6/   $��175,0,703,130q�6R   $��Bottom=�6i   $��47��6�   $	��103��6�    �� 	IsDefault . 6�   �� 5    
   -   5        $ button1��5        	 yuyan#���  6"   $��20(�6D   $
��Left=�6R   $��Bottom=�6m   $��47��6�   $	��103��6�   6�   �� 5!   
   -   5        $ button_Copy��5!      $��20(�6&    
 quxiao#���  64   $��0,0,167,130q�6W   $��Bottom=�6l   $��Right=�6�   $	��103��6�   $��47��6�    �� IsCancel . 6�   �� 5"   
   $
��Left=�6   $��21,206,0,342q�60   $	��144��6F   .+�5#      �� $��/images/subway.jpg��6   $	��172��60    J� RenderTransformOrigin$ 0.548,0.275&�6=   5$      5&      5'      