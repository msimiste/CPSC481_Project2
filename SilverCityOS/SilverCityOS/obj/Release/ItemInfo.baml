   M S B A M L   `   `   `  ���� G  CSilverCityOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SilverCityOSSilverCityOS      SilverCityOS.ItemInfo   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:SilverCityOS       � Title$  ItemInfo��$
��1000��$
��1400�� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency .  � WindowStyle$
 None=�����  �� Color$ White�� �� Opacity$ 0Q�.���� 
���   �$��1 1 1 1q�$	��900��$
��1150��._�� ���#FFF � RowDefinitions �� $��* ��� $��8* �.+��� $��1�� �� Padding$ 20 10 20 20q�._��� -    ��Name$ itemImg��$��Pictures/testImage2.jpg��$��UniformToFill=��� -   	 ��Name$	 itemName��$	��100��$��10,10,10,-21q�$��Center=�$
��Bold"�$��40(�$
��30 0q�$��	Item Name���� -   $	 	itemPrice��$	��100��$��Italic$�$��40(�$��Right=�$
��50 0q�$��Center=�$��Price $$$$$��$��10,10,10,-21q��� -   
���   �$��2q�$��2��$��	75 0 0 43q�$��80 0 0 0q�$	��250��$	��100��
�������$��Bottom=�$
��Left=�.���� $��0q�
 �� TextWrapping$

 Wrap=�$��30(�$��Center=�$��Center=� J� IsHitTestVisible .  $��5 0 5 0q�.��Add Item To Order����  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R���  ��Name$ border��
���   �
������� �� CornerRadius$ 5��$��4q�$ 80 0 0 0q�._��� $��Center=�$��Center=�$
��Bold"��� -   ���#FFF$	��130��$	��130��$��5q�$��1��$��Bottom=�$
��Left=�$��	30 0 0 30q����� " ��.���  �@J�Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��   	Direction$	 230Q�   ShadowDepth$ 5Q�   
BlurRadius$ 7Q�   Opacity$	 0.8Q���  � �� �� " ��.R�� .+�A� 
���   �$��3������  �� ImageSource$% Pictures/ScreenElement/add2.png���� $��Center=�$	��Top=��� 
������ $��0q�$��2��$��80��$��80��$	��Top=�$��Right=�$��0 -40 -40 0q� �� IsCancel . ���� " ��.���  �@J�Effect   $ Black��$	 230Q�$ 3Q�$ 4Q�$	 0.8Q���  � �� �� " ��.R�� .+�A� 
���   �$	��1.5������ $' !Pictures/ScreenElement/delete.png���� $��Center=�$	��Top=�