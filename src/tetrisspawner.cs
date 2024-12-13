using Godot;
using System;



public partial class TetrisSpawner : Node
{
	// [NodePath($"../Broad")]
	public Board _board;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_board = GetNode<Board>($"../Board");
		if (_board == null)
		{
			GD.PrintErr("Board node not found!");
			return;
		} else {
			GD.Print("heihei");
		}

		Globals.TetrisType current_tetris = Helpers.enumvalue_helper<Globals.TetrisType>();
		_board.tetris_spawn(current_tetris, false);
	}
}
