using Godot;
using Godot.Collections;
using System;


public partial class Tetris : Node2D
{
	public TetrisProperty tetris_property;
	public bool is_next_tetris;
	public Vector2 spawn_position;
	public Vector2[] tetris_blocks;
	public Array<Block> blocks = new Array<Block>();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// preload
		PackedScene block_scene = GD.Load<PackedScene>("res://scenes/block.tscn");

		tetris_blocks = Globals.TetrisComposition.blocks[tetris_property.tetris_type];
		foreach(Vector2 tetris_block in tetris_blocks){
			Block block = block_scene.Instantiate<Block>();
			blocks.Add(block);
			AddChild(block);
			block.set_texture(tetris_property.tetris_texture);
			block.Position = tetris_block * block.get_size();
		}
	}

	// // Called every frame. 'delta' is the elapsed time since the previous frame.
	// public override void _Process(double delta)
	// {
	// }
}
