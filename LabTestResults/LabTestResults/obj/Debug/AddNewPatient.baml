   M S B A M L   `   `   `  ����  LabTestResults"    LabTestResults.AddNewPatient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��AddPatientWindow��5   	     � Title$  AddNewPatient��5   	   $	��439��6   $��516.5��6,   .��5      � $��0,0,0,6q�6   ���	#FF3A0018$
��Left=�63   $	��505��6N   .+�5	   
   �� $��Registration Information��6   $
��Left=�65   $	��Top=�6P   $	��210��6h   $	��158��6t   $��	292,4,0,0q�6�   $��Italic$�6�   
�������.��5
      �  � Orientation$ 
Horizontal=�6   $��	1,3,-1,-3q�61   ���	#FFFFB900.+�5      �� $��	Asisstant��6   $
��Left=�6,   $��5,10,0,0q�6G   $	��Top=�6Z   $��59��6r   �� 5      $��Right=�6   $	��Top=�67   $	��120��6O   $��5,10,0,0q�6[   �� 5      $��Test ��6   $	��Top=�6(   $��
15,15,18,0q�6@   $��35��6T   �� 5      -   5        $��testsComboBox��5      $
��Left=�61   $	��Top=�6L   $��0,15,0,5q�6d   $	��121��6v   .@�5      �� -   5        $��urinaTestItem��5   #   .��68   
Urina Test6D   �� 5      -   5        $��generalBloodTestItem��5   #   .��6?   General Blood Test6S   �� 5      -   5        $��carbohydrateTestItem��5   #   .��6?   Carbohydrate Metabolism Test6]   �� 5      -   5        $��proteinTestItem��5   #   .��6:   Protein Metabolism Test6S   �� 5      -   5        $��vitaminsTestItem��5   #   .��6;   Vitamins Test6J   5      5      5      �� 5   
   $�� ��6   $
��Left=�6   $��
100,17,0,0q�66   $	��Top=�6J    J� RenderTransformOrigin$ 0.105,-0.423&�6b   �� 5   
   $�� ��6   $
��Left=�6   $��
100,17,0,0q�66   $	��Top=�6J   $ 0.105,-0.423&�6b   �� 5   
   -   5         ��Name$ btnAddPatient��5      $��Add Patient��6(   $
��Left=�6>   $��305,364,0,0q�6Y   $	��Top=�6n   $	��189��6�   $��28��6�   $��Italic$�6�   
�������6�   &   System.Windows.Controls.Calendar  5   
   $
��Left=�6   $��312,180,0,0q�6.   $	��Top=�6C   $	��171��6[   $	��172��6h   �� 5   
   $��Patient Information��6   $
��Left=�60   $��5,4,0,1q�6K   $	��279��6\   $��Italic$�6h   
�������.��5      � $
��Left=�6   $	��269��63   $��0,1,-2,5q�6?   ���	#FFFFB900.+�5      �� $
��Name��6   $
��Left=�6(   $	��Top=�6D   $��	10,15,5,5q�6\   $ 0.184,7.808&�6p   $��Italic$�6�   �� 5       -	   5         ��Name$ txtName��5       $
��Left=�6+   $��24��6F   $��	55,15,5,5q�6R    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��131��6�   $ 0.233,-0.139&�6�   �� 5!      $��	Last name��6   $
��Left=�6,   $��	10,15,5,5q�6H   $	��Top=�6\   $ 0.184,7.808&�6t   $��Italic$�6�   �� 5"      -
   5        $ txtLastName��5"      $��	35,15,5,5q�6/   $
��Left=�6C   $��24��6^   $
 Wrap=�6j   $	��Top=�6~   $	��131��6�   �� 5#      $��Gender��6   $
��Left=�6)   $��	10,15,5,5q�6E   $	��Top=�6Y   $ 0.105,-0.423&�6q   $��Italic$�6�   	� 5$      -   5         	�Name$ rbtnMale��5$      $
��Male��60   $��	45,20,5,5q�6@   $
��Left=�6T   $	��Top=�6o   $��Italic$�6�   	� 5%      -   5        $ rbtnFeamale��5%      $��Female��63   $��	10,20,5,5q�6E   $
��Left=�6Y   $	��Top=�6t   $��Italic$�6�   �� 5&      $��Date of birth��6   $��5,15,5,5q�61   $
��Left=�6D   $	��Top=�6_   $ 0.105,-0.423&�6w   $��Italic$�6�   (  "System.Windows.Controls.DatePicker  5'      -   5          Name$ Calendar��5'      $��	30,15,5,5q�6/   $
��Left=�6C   $	��Top=�6^   $	��129��6v   $��Italic$�6�    � LayoutTransform 5(      V� 5)      .~�5*      �� �� 5+      �� 5,      T� 5-      5.      50      �� 51      $��Place of resistance��6   $��1,15,5,5q�66   $
��Left=�6I   $	��Top=�6d   $��Italic$�6|   �� 52      -   5        $ txtPlaceOfResistance��52      $��7,15,5,0q�68   $
��Left=�6K   $��22��6f   $
 Wrap=�6r   $	��Top=�6�   $	��126��6�   �� 53      $��Type of blood��6   $
��Left=�60   $��	10,15,0,5q�6K   $	��Top=�6_   $��Italic$�6w   �� 54      -   5        	 ��Name$	 bloodSlider��54      
 �� IsSnapToTickEnabled
 . $
��Left=�6I   $��	26,20,5,5q�6e   $	��Top=�6y   $��51��6�    � Maximum$ 4Q�6�    � SmallChange$ 0Q�6�   �� 55      -   5        $ txtBloodType��55      $
��Left=�60   $��23��6�   $��5,15,5,5q�6�   $
 Wrap=�6�   $	��Top=�6�   $��63��6�   ��6K   ��  �� ElementName$ bloodSlider�� �� Path$ Value�6�   �� 56      $��email��6   $��	15,15,5,5q�6(   $
��Left=�6<   $	��Top=�6W   $��Italic$�6o   �� 57      -   5        $ txtEmail��57      $��	60,15,5,0q�6-   $
��Left=�6A   $��22��6\   $
 Wrap=�6h   $	��Top=�6|   $	��126��6�   �� 58      $��Phone number��6   $��	10,15,5,5q�60   $
��Left=�6D   $	��Top=�6_   $ 0.342,0.808&�6w   $��Italic$�6�   �� 59      -   5        $ txtPhoneNumber��59      $��	19,15,5,5q�62   $
��Left=�6F   $��23��6a   $
 Wrap=�6m   $	��Top=�6�   $	��126��6�   5:      5;      5=      5>      