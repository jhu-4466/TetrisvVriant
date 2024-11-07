using Godot;
using System;


/*
* every tetris piece size is 18*18 (one line can hold 18 pieces)
*/

public partial class tetrisproperties : Resource
{
    // Export as a visible attribute to the engine 
    [Export] 
    public Texture tetris_texture { get; set; }
    [Export] 
    public globals.Tetromino tetromino_type { get; set; }
    [Export] 
    public Vector2 spawn_position { get; set; }
}
