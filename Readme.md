# How to modify brick appearance using styles


<p>This example demonstrates how to modify brick appearance using styles.</p><p>Bricks appearance can be set up in several ways. The most advanced approach is to use the <strong>BrickStyle</strong> class. This class provides all graphical properties, which are required to draw bricks of any type. Different class instances can be created to represent different styles used in a report. Moreover, different brick styles can be assigned to bricks of different types. Then, all modifications done with a specific <strong>BrickStyle</strong> apply to all bricks drawn with this style. This simplifies the customization of brick groups drawn with a specific style.</p><p>The following code arranges text bricks in three columns. Each column has its own <strong>BrickStyle</strong>. All style settings are defined in the <strong>BrickStyle</strong>'s constructors. Text bricks are created via the <strong>BrickGraphics.DrawString</strong> method. This method does not affect graphical properties of the <strong>TextBrick</strong> already defined via the <strong>BrickStyle</strong>.</p>

<br/>


