   M S B A M L   `   `   `  ���� G  CSilverCityOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SilverCityOSSilverCityOS      SilverCityOS.ucMenuItem   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:SilverCityOS     .���� $��4,2,4,2q�
���   �._�� -     �Name$  mainGrid�����#FFF$	��250�� � ColumnDefinitions �� $��0.85* ��� $��* ��� $
��1.5* �.+��� -    ��Name$ btnAdd�����#FFF$	��130��$	��130��$��5q�����  �� 
TargetType" ��.���  �� Property �@J�Effect �� Value 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��   	Direction$	 230Q�   ShadowDepth$ 5Q�	   
BlurRadius$	 7Q�
   Opacity$	
 0.8Q���  � �� ��  �� 
TargetType" ��.R�� .+�A� 
���   �$��3������  �� ImageSource$% Pictures/ScreenElement/add2.png���� $��Center=�$	��Top=��� -   $ 
addClicked�����#FFF$	��130��$	��130��$��5q����� " ��.���  �@J�Effect   $ Black��$	 230Q�$ 5Q�$	 7Q�$	
 0.8Q���  � �� �� " ��.R�� .+�A� 
���   �$��3������ $+ %Pictures/ScreenElement/addClicked.png���� $��Center=�$	��Top=�� $��1��.+��� -   $ btnImage��$��20q�$��2q�
���   �.���� -    ��Name$ itemImg��$$��Pictures/ScreenElement/add.png��$��UniformToFill=��� $&�� Pictures/ScreenElement/zoom3.png��$��25q�$��50��$��Right=�$	��Top=� J� IsHitTestVisible .  �� $��2��$��Center=�$��Stretch=�.+���  �� Orientation$ 
Horizontal=�.+��� -    ��Name$ 
itemNumber��$	��Top=�$��0q�$��10 0 0 0q�$��30(�$��Right=�$
��Bold"� .  .��Item #�� -   $ itemName��$��Bottom=�$��0q�$��0q�$	��430��$��30(�$��Center=� �� TextWrapping$
 Wrap=�$
��Bold"� .  .��Name�� $ 
Horizontal=�$��Center=�$	��Top=�.+��� -    ��Name$ itemPriceFront��$��90(�$��Center=�$	��Top=�$	��$15��$��SketchFlow Print)��� -	   $ itemPriceBack��$��40(�$
��Left=�$��Center=�$��	0,0,10,40q�$
��Bold"�$��00��$��SketchFlow Print)�