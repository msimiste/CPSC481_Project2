   M S B A M L   `   `   `  ���� G  CSilverCityOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SilverCityOSSilverCityOS      SilverCityOS.Prompt   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:SilverCityOS       � Title$  Prompt��$	��700��$
��1050�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .  � 	Resources    okbutton  
menubutton �� BasedOn �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name �� CornerRadius �� Padding  
showbutton �� Triggers P� Property P� Value �� 
TargetName3  -System.Windows.Media.Effects.DropShadowEffect   Color   	Direction   ShadowDepth   
BlurRadius   Opacity��%f  &	        7  &	 �     7  �� 8   " ��.���  � ��$	 300����  � ��$ 90����  � �� �� "	 ��.R��� $
 border��
���   ����#3d5afe$ 5��$��4q�$ 2q�._��� $��Center=�$��Center=�$
��Bold"��� 8   " ��.���  � ��$ 30(���  � �� �� "	 ��.R��� $
 border��
���   ����#737373$ 5��$��4q�$ 2q�._��� $��Center=�$��Center=�$
��Bold"� P�  � {� .  . ��� $ border�� � ��
 �������  � ��
 �   ��� $ border�� � ��$ 3q���  �@J�Effect   $ Black��$	 220Q�$ 0Q�$ 0Q�$ 0Q�����  �� Color$ Transparent��.���� 
���   �$��1q�$	��600��$	��950��._�� -    �Name$ mainGrid�����#FFF � RowDefinitions �� $��3* ��� $��* � � ColumnDefinitions �� $��* ��� $��* �.+��� -    ��Name$ 	mainStack��$��2��$��Center=�.+��� -    ��Name$ message��$��Center=�$��Stretch=�$��
80 50 80 0q� �� TextAlignment$ Center=�$��40(� �� Padding$
 30 0q�$
��Wrap=�Waiter Has Been Notified� -   $ 	middleSec��$	��275��$��
70 10 70 0q� �� $��* ��� $��* �.+��� -    ��Name$ modePic��$)��#Pictures/ScreenElement/Takeout2.png���� -   $ 
rightStack��$��2��.+��� -    ��Name$ showBill��$��80��$	��250��$��0 30 0 0q�$
��Bold"�#��[ .��	View Bill�� -     ��Name$  itemListScroll��$	��275��$
��Auto=�! �� PanningMode$
! Both=�.���� -	   $ itemList���� -
   $��2��$��1��#��[  $��OK��$
��Bold"�$��40(��� -   $ closeButton��$��2��
������ $��0q�$��80��$��80��$	��Top=�$��Right=�$��0 -40 -40 0q�" �� IsCancel" . ���� " ��.���  �@J�Effect   $ Black��$	 230Q�$ 3Q�$ 4Q�$	 0.8Q���  � �� �� "	 ��.R�� .+�A� 
���   �$	��1.5������ # �� ImageSource$'# !Pictures/ScreenElement/delete.png���� $��Center=�$	��Top=�