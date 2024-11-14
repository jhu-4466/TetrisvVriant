using Godot;
using System;



public partial class tetrisspawner : Node
{
	// [NodePath($"../Broad")]
	public board _board;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_board = GetNode<board>($"../Board");
		if (_board == null)
		{
			GD.PrintErr("Board node not found!");
			return;
		} else {
			GD.Print("heihei");
		}

		globals.TetrisType current_tetris = helpers.enumvalue_helper<globals.TetrisType>();
		_board.tetris_spawn(current_tetris, false);
	}
}
