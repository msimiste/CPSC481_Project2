   M S B A M L   `   `   `  ����G  CSilverCityOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SilverCityOSSilverCityOS  5   	       SilverCityOS.ItemInfo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SilverCityOS     5   	     � Title$  ItemInfo��5   	   $
��1000��6   $
��1400��6(    � WindowStartupLocation$ CenterScreen=�65    � AllowsTransparency .  � WindowStyle$
 None=�6t   ��5	      �� 5
   
    �� Color$ White��6    �� Opacity$ 0Q�6(   .��5      �� 
���   �$��1 1 1 1q�6!   $	��900��6;   $
��1150��6H   ._�5   
   � ���#FFF � RowDefinitions 5      �� 5      $��* �6    �� 5      $��8* �6    .+�5      �� $��1��6    �� Padding$ 20 10 20 20q�6"   ._�5      �� -   5         ��Name$ itemImg��5      $��Pictures/testImage2.jpg��6)   $��UniformToFill=�6J   5      �� 5      -   5        	 ��Name$	 itemName��5      $	��100��6&   $��10,10,10,-21q�63   $��Center=�6I   $
��Bold"�6k   $��40(�6}   $
��30 0q�6�   $��	Item Name��6�   �� 5      -   5        $	 	itemPrice��5      $	��100��6'   $��Italic$�64   $��40(�6G   $��Right=�6U   $
��50 0q�6q   $��Center=�6�   $��Price $$$$$��6�   $��10,10,10,-21q�6�   �� 5      -   5        
���   �$��2q�5   )   $��2��6=   $��	75 0 0 43q�6J   $��80 0 0 0q�6]   $	��250��6p   $	��100��6|   
�������$��Bottom=�6�   $
��Left=�6�   .��5      �� $��0q�6   
 �� TextWrapping$

 Wrap=�6.   $��30(�6B   $��Center=�6P   $��Center=�6r    J� IsHitTestVisible .  $��5 0 5 0q�6�   .��6�   Add Item To Order6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value 5      �� 5   "    �� 
TargetType" ��62   .R�5   &   ��  ��Name$ border��6-   
���   �
������� �� CornerRadius$ 5��6d   $��4q�6u   $ 80 0 0 0q�6�   ._�5    *   �� $��Center=�6;   $��Center=�6X   $
��Bold"�6s   5!   '   5"   #   5$      5%      5'      �� 5(      -   5        ���#FFF$	��130��5(   '   $	��130��64   $��5q�6@   $��1��6g   $��Bottom=�6t   $
��Left=�6�   $��	30 0 0 30q�6�   ��5)      �� 5*      " ��6   .�5+      ��  �@J�Effect 5,      3  -System.Windows.Media.Effects.DropShadowEffect  5-   "      Color$ Black��63      	Direction$	 230Q�6A      ShadowDepth$ 5Q�6Q      
BlurRadius$ 7Q�6a      Opacity$	 0.8Q�6p   5/      �� 50       � �� 51      �� 52   "   " ��62   .R�53   &   � .+�54   *   A� 
���   �$��3��6A   ��55   .   �� 56   2    �� ImageSource$% Pictures/ScreenElement/add2.png��6=   58   +   �� 59   *   $��Center=�6;   $	��Top=�6X   5:   '   5;   #   5=      5>      5@      �� 5B      
������ $��0q�6.   $��2��6B   $��80��6R   $��80��6^   $	��Top=�6i   $��Right=�6�   $��0 -40 -40 0q�6�    �� IsCancel . ��5C      �� 5D      " ��6   .�5E      ��  �@J�Effect 5F        5G   "   $ Black��63   $	 230Q�6A   $ 3Q�6Q   $ 4Q�6a   $	 0.8Q�6p   5I      �� 5J       � �� 5K      �� 5L   "   " ��62   .R�5M   &   � .+�5N   *   A� 
���   �$	��1.5��6A   ��5O   .   �� 5P   2   $' !Pictures/ScreenElement/delete.png��6=   5R   +   �� 5S   *   $��Center=�6;   $	��Top=�6X   5T   '   5U   #   5W      5X      5Z      5[      5\      5]      