   M S B A M L   `   `   `  ����I  ELabTestResults, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LabTestResultsLabTestResults  5   	       LabTestResults.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:LabTestResults     5   	   -   5          �Name$  
mainWindow��5   	   $	��654��5      $
��1086��6'   
���   �.��5	      � -   5         �Name$ gridMain��5	      ���	#FF3A0018 J� OpacityMask �	#FFE2CBE6 � RowDefinitions 5
   
   �� 5      $	��27* �6   �� 5      $
��364* �6   �� 5      $
��232* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dataGrid��5      $��Stretch=�6&   $��30,10,30,11q�6F   "   VerticalScrollBarVisibility$
 Auto=�6[   $   HorizontalScrollBarVisibility$
 Auto=�6�   $��1��6�   ���	#FFFFB900
�������
 �����   HorizontalGridLinesBrush �	#FF9600FD   VerticalGridLinesBrush �	#FF9600FD   RowBackground �	#FFFFFA98	   AlternatingRowBackground	 �	#FFFBC9C9$��2q�6�  
 � ContextMenu
 5      �� 5      .@�5      m� -   5        $��Show Patient Results��5      69   m� 5      -   5        $��Add Patient Result��5      6;   m� 5      -   5        $��Dele Patient��5   #   69   �� 5      m� 5      $��Edit Patient Information��6   5      5      o� 5   
   -   5        $
��menu��5      $
��Left=�6   $��20��68   $	��Top=�6D   $	��135��6\   $��Italic$�6h   ���	#FF3A0018 J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2,1,0,0q�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.048Q�6*   T� 5       5!      .@�5#      m� $
��FILE��6   $��21��6)   $��Normal$�65   
����������	#FF3A0018&   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6r      TextHintingMode$ Animated=�6�   $��12(�6�   $��45��6�   ���	#FF3A0018$��0q�6�   .@�5$      m� -   5        $��Add Patient��5$      $��Normal$�60   
���   �$ Display=�6V   $ Animated=�6   $��10(�6�   5%      m� 5&      -	   5        $��Show Patients��5&      $��Normal$�62   
���   �$ Display=�6X   $ Animated=�6�   $��10(�6�   5'      �� 5)      m� 5*      -
   5        $
��Exit��5*      $��10(�6?   
���   �6M   5+      m� 5,      $
��EDIT��6   $��Normal$�6&   $��21��69   
�������$��45��6X   ���	#FF3A0018$ Display=�6{   $ Animated=�6�   $��12(�6�   ���	#FF3A0018$ 0.5,0.5&�6�   z�5-      V� 5.      .~�5/      �� �� 50      �� 51      $ -0.205Q�6*   T� 52      53      56      m� 57      $
��HELP��6   $��Normal$�6&   $��21��69   
�������$��45��6   ���	#FF3A0018$ Display=�6�   $ Animated=�6�   $��12(�6�   ���	#FF3A0018��6X   �� *GroupByOptions+.@�58      m� $��Information��6   $ Animated=�60   $ Display=�6W   
���   �6�   59      5:      �� 5<   
   $��MedicalTestResults��6   $��Stretch=�6/   $��
32,2,30,16q�6M   $��2��6a   $��Stretch=�6n   $��Italic$�6�   
�������
�������$��1q�6�   .��5=      �� -   5        $��Search By Name��5=      $��Bottom=�6/   $��30��6h   $��
36,0,0,110q�6t   $
��Left=�6�   $	��120��6�   5>      �� 5?   
   -   5        $��NameOfPatient��5?      $
��Left=�6(   $��30��6C   $��	74,31,0,0q�6O   $��2��6b    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��120��6�   
�������$ 
0.45,1.604&�6�   .��6�   5@      �� 5B   
   -   5        $��Search By Test��5B      $
��Left=�6+   $��30��6H   $��
596,28,0,0q�6T   $��2��6h   $	��Top=�6u   $	��118��6�   $��Italic$�6�   5C      �� 5D   
   -   5        $��testsComboBox��5D   "   $��2��6   $
��Left=�68   $	��120��6S   $��
596,71,0,0q�6_   $��32��6s   $	��Top=�6   .@�5E      �� -   5        $��urinaTestItem��5E      .��60   
Urina Test6<   �� 5F      -   5        $��generalBloodTestItem��5F      .��67   General Blood Test6K   �� 5G      -   5        $��carbohydrateTestItem��5G      .��67   Carbohydrate Metabolism Test6U   �� 5H      -   5        $��proteinTestItem��5H      .��62   Protein Metabolism Test6K   �� 5I      -   5        $��vitaminsTestItem��5I      .��63   Vitamins Test6B   5J      �� 5L   
   -   5        $��asistantsComboBox��5L   "   $��2��6   $
��Left=�6<   $	��Top=�6W   $��
342,73,0,0q�6o   $	��120��6�   $��30��6�   .@�5M      �� -   5        $��br��5M      .��6%   Nicolas Browdi65   �� 5N      -   5        $��qc��5N      .��6%   
Quon Carey61   �� 5O      -   5        $��mp��5O      .��6%   Maggie Perry63   �� 5P      .��6   Mechelle Lawrence6.   �� 5Q      .��6   Florence Henry6+   �� 5R      .��6   Daquan Walters6+   �� 5S      .��6   Castor Hatfield6,   �� 5T      .��6   MacKenzie Craig6,   �� 5U      .��6   Blythe Chambers6,   �� 5V      .��6   
Ebony Bird6'   �� 5W      .��6   Duncan Gibbs6)   �� 5X      .��6   Lisandra Hoover6,   �� 5Y      .��6   Larissa Osborne6,   �� 5Z      .��6   Duncan Gibbs6)   �� 5[      .��6   Nadine Galloway6,   �� 5\      .��6   Bryar Leach6(   �� 5]      .��6   Lisandra Hoover6,   �� 5^      .��6   Larissa Osborne6,   �� 5_      .��6   
Fleur Bond6'   �� 5`      .��6   Nyssa Morales6*   �� 5a      .��6   Hyacinth Harrington60   5b      �� 5c   
   -   5        $��Search By Asistent��5c      $
��Left=�6.   $��30��6I   $��
342,30,0,0q�6U   $��2��6i   $	��Top=�6v   $	��120��6�   $��Italic$�6�   �� 5d   
   $�� ��6   $
��Left=�6   $��30,1,0,0q�66   $	��Top=�6H   $��30��6`   $��1��6l   $��10��6y   &   System.Windows.Controls.Calendar  5e   
   $
��Left=�6   $��
808,26,0,0q�6.   $��2��6B   $	��Top=�6O   $	��226��6g   5f      5g      