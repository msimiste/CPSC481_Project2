   M S B A M L   `   `   `  ����G  CSilverCityOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SilverCityOSSilverCityOS  5          SilverCityOS.ucMenuItem   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:SilverCityOS     5      .��5	      �� $��4,2,4,2q�6   
���   �._�5
   
   � -   5          �Name$  mainGrid��5
      ���#FFF$	��250��63    � ColumnDefinitions 5      �� 5      $��0.85* �6#   �� 5      $��* �6#   �� 5      $
��1.5* �6#   .+�5      �� -   5         ��Name$ btnAdd��5      ���#FFF$	��130��67   $	��130��6D   $��5q�6P   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property �@J�Effect �� Value 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   "      Color$ Black��63      	Direction$	 230Q�6A      ShadowDepth$ 5Q�6Q   	   
BlurRadius$	 7Q�6a   
   Opacity$	
 0.8Q�6p   5      �� 5       � �� 5      �� 5   "    �� 
TargetType" ��62   .R�5   &   � .+�5   *   A� 
���   �$��3��6A   ��5   .   �� 5   2    �� ImageSource$% Pictures/ScreenElement/add2.png��6=   5!   +   �� 5"   *   $��Center=�6;   $	��Top=�6X   5#   '   5$   #   5&      5'      5)      �� 5+      -   5        $ 
addClicked��5+      ���#FFF$	��130��6;   $	��130��6H   $��5q�6T   ��5,      �� 5-      " ��6   .�5.      ��  �@J�Effect 5/        50   "   $ Black��63   $	 230Q�6A   $ 5Q�6Q   $	 7Q�6a   $	
 0.8Q�6p   52      �� 53       � �� 54      �� 55   "   " ��62   .R�56   &   � .+�57   *   A� 
���   �$��3��6A   ��58   .   �� 59   2   $+ %Pictures/ScreenElement/addClicked.png��6=   5;   +   �� 5<   *   $��Center=�6;   $	��Top=�6X   5=   '   5>   #   5@      5A      5C      � 5D      $��1��6   .+�5E      �� -   5        $ btnImage��5E      $��20q�6+   $��2q�67   
���   �.��5F      �� -   5         ��Name$ itemImg��5F      $$��Pictures/ScreenElement/add.png��6-   $��UniformToFill=�6U   5G      �� 5H      $&�� Pictures/ScreenElement/zoom3.png��6   $��25q�6B   $��50��6N   $��Right=�6Z   $	��Top=�6v    J� IsHitTestVisible .  6�   5I      �� 5J      $��2��6   $��Center=�6)   $��Stretch=�6D   .+�5K      ��  �� Orientation$ 
Horizontal=�6!   .+�5L      �� -   5         ��Name$ 
itemNumber��5L   "   $	��Top=�66   $��0q�6N   $��10 0 0 0q�6b   $��30(�6t   $��Right=�6�   $
��Bold"�6�    .  .��6�   Item #6�   �� 5M      -   5        $ itemName��5M   "   $��Bottom=�64   $��0q�6O   $��0q�6c   $	��430��6n   $��30(�6z   $��Center=�6�    �� TextWrapping$
 Wrap=�6�   $
��Bold"�6�    .  .��6�   Name5O      5P      �� 5Q      $ 
Horizontal=�6!   $��Center=�6:   $	��Top=�6W   .+�5R      �� -   5         ��Name$ itemPriceFront��5R      $��90(�64   $��Center=�6B   $	��Top=�6_   $	��$15��6w   $��SketchFlow Print)�6�   �� 5S      -	   5        $ itemPriceBack��5S      $��40(�63   $
��Left=�6A   $��Center=�6\   $��	0,0,10,40q�6w   $
��Bold"�6�   $��00��6�   $��SketchFlow Print)�6�   5T      5U      5V      5W      5X      