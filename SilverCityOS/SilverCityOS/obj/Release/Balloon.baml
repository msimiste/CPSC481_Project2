   M S B A M L   `   `   `  ����   SilverCityOS    SilverCityOS.Balloon   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     $	��120��$	��250��  � WindowStyle$
  None=� � 
ResizeMode$ NoResize=� � ShowInTaskbar .   � ShowActivated .   � Topmost . ��.   � OverridesDefaultStyle .   � SizeToContent$ Height=� � AllowsTransparency . 
������  � 	Resources 	 �� 
StartPoint
 �� EndPoint   HelpGradient �� RelativeTransform �� Angle �� CenterX �� CenterY � Color � Offset  InfoGradient  WarningGradient��%�  &	        &	 ~     &	 �     �� $		 0,0&�$	
 1,0&� �� $ 90Q�$	 0.7Q�$	 0.7Q�.��� $ 	#FFFDFDFD��$ .2Q�� $ 	#FFB6FB88��$ .8Q��� $		 0,0&�$	
 1,0&� �� $ 90Q�$	 0.7Q�$	 0.7Q�.��� $ 	#FFFDFDFD��$ .2Q�� $ 	#FF88CEFB��$ .8Q��� $		 0,0&�$	
 1,0&� �� $ 90Q�$	 0.7Q�$	 0.7Q�.��� $ 	#FFFDFDFD��$ .2Q�� $ 	#FFF7FB88��$ .8Q�.���  J� RenderTransformOrigin$	 0,1&�.+���  �� Orientation$ Vertical=�.+��  � ColumnDefinitions �� $
��Auto ��� $��* �  �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   Color   Opacity��%�   'F�       �� " F�.���  � �� �#fdfdfd��  �@��Stretch$
 Fill=���  � ��$ 22����  � ��$ 31����  �@K�ZIndex$ 99����  � ��$	 Top=���  �@J�Effect   $ 	#FF757575��$ .7Q�.+�F� -    F�Name$ PathPointLeft��$��0��$
��Left=�$��15,3,0,0q�'����W`��~Q�@�qO���  �	 �`�
  �E	F� -   $ PathPointRight��$��1��$��Right=�$��0,3,15,0q�1�����"��~Q�@�qObX9d�@�њ��^
@�`�
  �E	F� -   $ PathPointBottomLeft��$��0��$��Right=�$��0,73.567,0.767,-70.567q�1����bX9d�@�qO�"��~Q�@�њ��^
��`�
  �E	$ 0.5,0.5&�#���    K� ZIndex$	 100��z�V� .~��� �� �� $ -179.033Q�T� F� -   $ PathPointBottomRight��$��1��$
��Left=�$��175.13,73.824,0,-70.824q�'����W`��~Q�@�qO���  �	 �`�
  �E	$ 0.5,0.5&�#���   $	 100��#���    J� OpacityMask# �   z�V� .~��� �� �� $ -181.104Q�T� �� -    ��Name$ borderBalloon��$��5,-3,5,5q� �� CornerRadius$ 7��$	 100��#��[ $	��Top=� J� Effect   $ 	#FF757575��$ .7Q�._��  �� $
��Auto ��� $��* ��� $
��Auto �.+��� -    ��Name$ 	imageType��$��0��$��35��$��5q�$	��Top=�$��35��$��Resources/information.png���� -   $ 
imageClose��$��Resources/delete24.png��  � ToolTip$  Close��$	��Top=�$��2��$��16��$��16��$��0,5,5,5q�$��1��! � Cursor$
! Hand���� $ Vertical=�$��1��$��0,5,5,5q�.+��� -   " ��Name$" textBlockTitle��&   System.Windows.Media.TextOptions#   TextFormattingMode$# Display=�$
��Bold"�$��14(�$��This is the Title���� -	   $ ��Name$$ 	lineTitle��% �� Stretch$
% Fill=�
���   �	& �� X2$& 1���� -
   ' ��Name$' scrollViewerCaption��$
��Auto=�.���� -   $" textBlockCaption��$
��Wrap=�$# Display=�$��This is the caption��z��� ( �� ScaleY$( 1Q�