   M S B A M L   `   `   `  ���� 
  Breeze    Breeze.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  Breeze�� � Icon$ icon.ico��$	��400��$	��300��$	��520��$	��625��   WindowStyle#��[   � WindowStartupLocation$ CenterScreen=�.��� ����  �� ImageSource$ Images/back.png�� j� Stretch$ UniformToFill=� �� Opacity$	 0.4Q� � RowDefinitions �� $��60 ��� $��* �.+��� $��0��$��0,0,0,1q����#8C8E94._��  � ColumnDefinitions �� $��60 ��� $��* ��� $��60 �.+�A� -    A�Name$ ProfileContainer��$��0��$��5q����#007ACC$��1��	 � Cursor$
	 Hand������ -   ProfileImage��$  Images/profile/profile.png���� -   
 ��Name$
 UserNameSurname�� �� Padding$ 5,3,0,0q�$��1��$�� ��$��20(�
�������$��Light"��� -   $
 UserCurrentStation��$ 5,27,0,0q�$��1��$�� ��$��20(�
�������$��Light"�r� -    r�Name$ MainMediaPlayer��$y�Visible=�$��2�� r� LoadedBehavior$ Manual=� r� Volume$	 100Q�d� -    d�Name$ PlayPauseButton��$��2��  PlayPauseButtonStyle#��[ $��Center=�$��Center=�$
��Auto��$��5q�� $��1�� �� $��* �.+��� $��0��$��0,0,1,0q����#8C8E94._��� 
������ .@��� $%��Мои радиостанции��.���� -    ��Name$ UserStationsList��$��Disabled=�$��0��
������   UserStationsListBoxStyle#��[ ���� .R��  �� $��30 ��� $��* �.+���  ��Name$ RemoveStationButton��-	   $��22��$��22��$��0��$��X��  RemoveStationButtonStyle#��[ �� $��1��$��16(�$��10,0,0,0q�
����������� *UserStationName+�� $)��#Найти радиостанции��.���  �� $	��140 ��� $��* �.+��� $��0�����#8C8E94$��0,0,1,0q�._��� -
   $ FindStationsTypes��$��Disabled=�
������    FindStationTypesListBoxStyle#��[   FindStationTypesListBoxItem#��[ 
�������.@��� $��16(�.��
Клуб�� $��16(�.��Поп�� $��16(�.��Рэп/Хипхоп/РнБ�� $��16(�.��Игровые�� $��16(�.��Рок�� $��16(�.��Подборка�� -   $ FindStationsNames��$��Disabled=�$��1��
������ #��[ 
�������$��16(����� .R��  �� $��30 ��� $��* �.+��� $ AddStationButton��-   $��22��$��22��$��0��$��+��#��[ �� $��1��$��16(�$��10,0,0,0q�
����������� *UserStationName+