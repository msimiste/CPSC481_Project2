   M S B A M L   `   `   `  ���� G  CSilverCityOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SilverCityOSSilverCityOS      SilverCityOS.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:SilverCityOS     -     �Name$  MainWindow1�� � Title$ 
MainWindow��$
��1080��$
��1920��$	��Top=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � WindowStyle$
 None=� � 	Resources    
helpbutton  
menubutton �� BasedOn �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name �� CornerRadius �� Padding  orderbutton3  -System.Windows.Media.Effects.DropShadowEffect   Color   	Direction   ShadowDepth   
BlurRadius   Opacity  spbutton  	paybutton��%�  &	        7  &	 �     7  &	 �    7  &	 �    7  �� 8   " ��.��� 	 � ��
 �� " ��.R��� $ border��
���   ����#666666$ 2��$��4q�$ 2q�._��� $��Center=�$��Center=�$
��Bold"��� 8   " ��.��� 	 � ��$	
 100���� 	 � ��$
 9,15,5,5q��� 	 � ��$
 5q��� 	 �@J�Effect
   $ Black��$	 230Q�$ 4Q�$ 4Q�$	 0.9Q��� 	 � ��
 �� " ��.R��� $ border��
���   ����#9fa8da$ 5��$��2q�$ 2q�._��� $��Center=�$��Center=�$
��Bold"��� 8   " ��.��� 	 � ��$
 9,5,7,0q��� 	 � ��$
 60���� 	 � ��$
 25(��� 	 � ��

 �   ��� 	 � ��
 �� " ��.R��� $ border��
���   ����#ffff4d$ 2��$��2q�$ 2q�._��� $��Center=�$��Center=�$
��Bold"��� 8   " ��.��� 	 � ��$
 80���� 	 � ��
 �� " ��.R��� $ border��
���   ����#7986cb$ 2��$��3q�$ 2q�._��� $��Center=�$��Center=�$
��Bold"�.��� -    �Name$ mainGrid�� � ColumnDefinitions �� $��* ��� $��3* ��� $��* �.+��� -    ��Name$ stkPanel_MenuPanel��$��0��$
��1080�� �� Orientation$ Vertical=�$	��Top=�
�������.+�d� -    d�Name$ btnCallWaiter��
���   ����� " d�.��� 	 � ��$
 	10,6,10,3q��� 	 �@J�Effect
   $ Black��$	 230Q�$ 4Q�$ 4Q�$	 0.9Q��� 	 � ��
 �� " d�.R��� $ wborder��
���   �
�������$ 5��$��2q�$ 2q�._��� $ 
Horizontal=�.+��� $&�� Pictures/ScreenElement/bell2.png��$	��150����  ��Name$ waiterTextbox��$��Center=�$��Center=�$	��158��$��30(�$	��100��$
��Bold"�$
��Wrap=� �� TextAlignment$ Center=�$��CALL WAITER�� �� Padding$ 0,10,0,0q� �� Triggers P�  P� Property �@d�	IsChecked P� Value$
 TrueY�. ���  �� 
TargetName$ wborder��	 � ��

 � ����� $ wborder��	 � ��$
 3q��� 	 � ��$
 10,6,10,1.25q��� $ waiterTextbox��	 � ��$
 CANCEL CALL WAITER���� $ waiterTextbox��	 � ��$
 30(��� $ waiterTextbox��	 � ��$	
 140���� 	 �@��Padding$
 0,10,0,0q��� 	 �@J�Effect
   $ Black��$	 220Q�$ 0Q�$ 0Q�$ 0Q��� $��0q�._��� -   $ controlSections��.+��� -     ��Name$  btnAppetizers��$��
Appetizers��#��[ �� -   $  btnSoup��$��Soups & Sizzling Rice��#��[ �� -   $  btnBeef��$
��Beef��#��[ �� -	   $  
btnChicken��$��Chicken & Duck��#��[ �� -
   $  
btnSeafood��$��Pork & Seafood��#��[ �� -   $  btnVegie��$��
Vegetables��#��[ �� -   $  btnHot��$��Hot Plates & Hot Pots��#��[ �� -   $  btnRice��$ ��Fried Rice & Fried Noodles��#��[ �� -   $  btnEgg��$��Egg Foo Young & Chop Suey��#��[ �� -   $  	btnDrinks��$��Drinks��#��[ �� -   $  btnHelp��$��	HELP INFO��#���   �� -   $ 	middleSec��$��1��.+��� -   ! ��Name$! lblCategories��
���   �$��4 4 4 4q�$	��100��$��70(�$��DemiBold"�$��Center=�$��Center=�.��SILVER CITY RESTAURANT�� -   " ��Name$" scrlViewer_MenuItems��$	��Top=�$	��980��$��Hidden=�# �� PanningMode$
# Both=�.���� -   $ sViewer_Stackpanel���� -   $ stkPanel_OrderPanel��$��2��
�������.+��� -   $! lblOrderItems��
���   �$��0 4 4 4q�$	��100��$��50(�$��DemiBold"�$��Center=�$��Center=�.��
ORDER LIST�� -   $" scrlViewerOrderItems��$	��575��$
��Auto=�$
# Both=�.���� -   $ 
orderItems���� -   $! 	lblSTotal��$��35��$��10 0 0 0q�$��0 0 20 0q�$��Stretch=�$��Right=�$��Bottom=�$��25(�.��Sub Total: $100.00�� -   $! lblTax��$��35��$��10 0 0 0q�$��0 0 20 0q�$��Stretch=�$��Right=�$��Bottom=�$��25(�.��Tax: $100.00�� -   $! lblTotal��$��45��
���   �$	��0 2q�$
��10 0q�$��0 0 10 0q�$
��Bold"�$��Right=�$��Stretch=�$��Bottom=�$��30(�.��Total: $1600.00�� -   $  btnSpecialNote��#��[ .��Dietary/Allergy Concerns� -   $ orderControlGrid�� �� $��* ��� $��* �$ � RowDefinitions$ �� $��* ��� $��* �.+��� -   $  	btnDineIn��$��0��#��[ .���� $ 
Horizontal=�.+��� $��80��$'��!Pictures/ScreenElement/DineIn.png���� $��80��
������ % �� TextWrapping$
% Wrap=�& J� IsHitTestVisible& .  $��Center=�$��Center=�$��22(�.��ORDER DINE IN�� -   $  
btnTakeOut��$��1��#��[ .���� $ 
Horizontal=�.+��� $��80��$)��#Pictures/ScreenElement/TakeOut2.png���� $��80��
������ $
% Wrap=�& .  $��Center=�$��Center=�$��22(�.��ORDER TAKE OUT�� -    $  
btnPayBill��$��2��$��2��#��[ .��� $	��300�� �� $��* ��� $��* �.+��� $��0��$��Right=�$��0 0 30 0q�$)��#Pictures/ScreenElement/PayBill2.png���� $
��Left=�$��Center=�$��	125,0,0,0q�$��30(�$��2��.��
PAY BILL� -!   $ upArrowCover��$��1��$��	0 100 0 0q�$	��100��$	��Top=�& .  .+��� ���� ' �� 
StartPoint$	' 0,0&�( �� EndPoint$	( 0,1&�.��� ) � Color$) Transparent��* � Offset$* 1Q�� $) 	#FFFFFFFF��$* 0Q��� $(��"Pictures/ScreenElement/arrowUp.png��$	��Top=�+ J� Opacity$	+ 0.3Q�$	��300��$	��100��� -"   $ downArrowCover��$��1��$	��150��$��Bottom=�& .  .+��� $	��1 0q����� $	' 0,0&�$	( 0,1&�.��� $) Transparent��$* 0Q�� $) 	#FFFFFFFF��$* 1Q��� $&�� Pictures/ScreenElement/arrow.png��$��Bottom=�$	+ 0.3Q�$	��300��$	��100���� -#   $  btnHelp1��$��60��$��60��$��Bottom=�$
��Left=�$��0q�
������ $��15q�