   M S B A M L   `   `   `  ����H  DBlackjackGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BlackjackGame.ViewsBlackjackGame.Views  5   	   $    BlackjackGame.Views.GameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BlackjackGame.Views     5   	     � Title$  
GameWindow��5   	   $	��300��6   $	��300��6)    � WindowState$ 	Maximized=�5	   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��.5* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��DealerPanel��5      $��0��6(   $��0��68   .+�5      �� -   5        $��DealerField��5       �� Orientation$ 
Horizontal=�6,   5      �� 5      -   5        $��DealerHandField��5      $ 
Horizontal=�60   5      5      �� 5   
   $��1��6   $��0��6%   .+�5       �� $��18(�6   
�������$��	underline{�69    �� TextAlignment$ Center=�6U   Score6s   �� 5!      
�������Dealer63   �� 5"      -   5        $��DealerScoreTextBlock��5"      $��20(�64   $
��Bold"�6B   
�������6i   5#      *  $System.Windows.Controls.DataGridCell  5%   
   -   5        $��NeutralZone��5%      $��0��6*   $��1��6:   5'      �� 5(   
   -   5        $��	DeckField��5(      $��1��6&   $��1��66   .+�5)      �� -   5        $��
DeckButton��5)      $	��100��6'   $	��100��64   ��5*      �� 5+       �� ImageSource$ /Assets/Deck.png��6!   5-      5.      �� 50   
   -   5        $��PlayerPanel��50      $��0��6(   $��2��68   .+�51      �� -	   5        $��PlayerField��51   2   $ 
Horizontal=�6   53      �� 54      -
   5        $��PlayerHandField��54      $ 
Horizontal=�60   56      57      �� 58   
   $��1��6   $��2��6%   .+�59      �� $��18(�6   
�������$��	underline{�69   $ Center=�6U   Score6s   �� 5:      -   5        $��PlayerTextBlock��5:   +   
�������6D   5;      ��5<   
   �� 5=       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5>      � 	 � Color$	 Black��6   
 � Offset$
 0Q�6-   � 5?      $	 	#FFA6FF68��6   $
 1Q�61   � 5@      $	 	#FF669D40��6   $
 1Q�61   � 5A      $	 	#FF9DF162��6   $
 1Q�61   5B      5D      5E      