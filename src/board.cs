using Godot;
using System;


public partial class Board : Node
{
	[Export] 
    public PackedScene tetris_scene { get; set; }
	
	public void tetris_spawn(Globals.TetrisType tetris_type, bool is_next_tetris, Vector2 spawn_position=default) {
		TetrisProperty tetris_property = Globals.tetris_resources[tetris_type];

		Tetris tetris = tetris_scene.Instantiate<Tetris>();
		tetris.tetris_property = tetris_property;
		tetris.is_next_tetris = is_next_tetris;
		if (!is_next_tetris) { // spawn demand
			tetris.spawn_position = new Vector2(-100, -150);
			AddChild(tetris);
		}
		
	}
}
