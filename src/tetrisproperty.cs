using Godot;
using System;


/*
* every tetris piece size is 18*18 (one line can hold 18 pieces)
*/

public partial class TetrisProperty : Resource
{
    // Export as a visible attribute to the engine 
    [Export] 
    public Texture2D tetris_texture { get; set; }
    [Export] 
    public Globals.TetrisType tetris_type { get; set; }
    [Export] 
    public Vector2 spawn_position { get; set; }
}
