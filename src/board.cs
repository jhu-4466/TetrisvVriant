using Godot;
using System;


public partial class board : Node
{
	[Export] 
    public PackedScene tetris_scene { get; set; }
	
	public void tetris_spawn(globals.TetrisType tetris_type, bool is_next_tetris, Vector2 spawn_position=default) {
		Resource tetris_property = globals.tetris_resources[tetris_type];

		tetris tetris_instant = (tetris) tetris_scene.Instantiate();
		tetris_instant.tetris_property = tetris_property;
		tetris_instant.is_next_tetris = is_next_tetris;
		if (!is_next_tetris) {
			tetris_instant.spawn_position = spawn_position;
			AddChild(tetris_instant);
		}
		
	}
}
