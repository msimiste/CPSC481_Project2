   M S B A M L   `   `   `  ���� G  CSilverCityOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SilverCityOSSilverCityOS      SilverCityOS.OrderedItem   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:SilverCityOS     .��� .+��� -     ��Name$  border�����#FFF$��2 2 2 2q�
���   �$��70�� �� Padding$ 0 0 0 0q�._�� -    �Name$
 main��$��70�� � ColumnDefinitions �� $
��0.7* ��� $��2* ��� $
��0.8* � � RowDefinitions �� $��* ��� $��* �.+��� -    ��Name$ 	buttonAdd��$��2��$��35��$��35������  �� 
TargetType" ��.���  �� Property �@J�Effect �� Value 3  -System.Windows.Media.Effects.DropShadowEffect  	   Color$	 Black��
   	Direction$	
 230Q�   ShadowDepth$ 3Q�   
BlurRadius$ 4Q�   Opacity$	 0.8Q���  � �� ��  �� 
TargetType" ��.R�� .+�A� 
���   �$	��1.5������  �� ImageSource$' !Pictures/ScreenElement/delete.png���� $��Center=�$	��Top=��� -    ��Name$ itemName��$��2��$��1��$��0q�$��Center=� �� TextAlignment$
 Left=�$��22(�
������  �� TextWrapping$
 Wrap=� J� IsHitTestVisible .  .��	ITEM NAME�� -   $ 	itemPrice��$��2��$��Center=�$ Right=�$��22(�$��0q�
������  .  .��$15.00� -   $ 
underPrice��$��3��$��2�� �� $��* ��� $��* �