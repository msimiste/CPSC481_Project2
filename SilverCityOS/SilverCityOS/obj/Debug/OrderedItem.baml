   M S B A M L   `   `   `  ����G  CSilverCityOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SilverCityOSSilverCityOS  5          SilverCityOS.OrderedItem   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:SilverCityOS     5      .��5	      � .+�5
   
   �� -   5          ��Name$  border��5
      ���#FFF$��2 2 2 2q�64   
���   �$��70��6b    �� Padding$ 0 0 0 0q�6n   ._�5      � -   5         �Name$
 main��5      $��70��6!    � ColumnDefinitions 5      �� 5      $
��0.7* �6'   �� 5      $��2* �6'   �� 5      $
��0.8* �6'    � RowDefinitions 5      �� 5      $��* �6$   �� 5      $��* �6$   .+�5      �� -   5         ��Name$ 	buttonAdd��5      $��2��6,   $��35��6S   $��35��6_   ��5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property �@J�Effect �� Value 5   "   3  -System.Windows.Media.Effects.DropShadowEffect  5   &   	   Color$	 Black��67   
   	Direction$	
 230Q�6E      ShadowDepth$ 3Q�6U      
BlurRadius$ 4Q�6e      Opacity$	 0.8Q�6t   5      �� 5       � �� 5   "   �� 5   &    �� 
TargetType" ��66   .R�5    *   � .+�5!   .   A� 
���   �$	��1.5��6E   ��5"   2   �� 5#   6    �� ImageSource$' !Pictures/ScreenElement/delete.png��6A   5%   /   �� 5&   .   $��Center=�6?   $	��Top=�6\   5'   +   5(   '   5*      5+      5-      �� 5.      -   5         ��Name$ itemName��5.      $��2��6,   $��1��6=   $��0q�6M   $��Center=�6a    �� TextAlignment$
 Left=�6�   $��22(�6�   
������  �� TextWrapping$
 Wrap=�6�    J� IsHitTestVisible .  .��6�   	ITEM NAME6�   �� 5/      -   5        $ 	itemPrice��5/      $��2��6-   $��Center=�6=   $ Right=�6_   $��22(�6u   $��0q�6�   
������  .  .��6�   $15.006�   � 50      -   5        $ 
underPrice��50      $��3��6+   $��2��6;    51      �� 52      $��* �6+   �� 53      $��* �6+   55      56      57      58      59      