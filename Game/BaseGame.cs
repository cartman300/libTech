﻿using FishGfx;
using FishGfx.Graphics;
using FishMarkupLanguage;
using libTech;
using libTech.Entities;
using libTech.Graphics;
using libTech.GUI;
using libTech.Importer;
using libTech.libNative;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Color = FishGfx.Color;

namespace Game {
	public unsafe class Game : LibTechGame {
		static string[] QuitPrompts = new string[] {
			"     Really?",
			"Whyyyyyyyyy?",
			"Are you sure you really want to quit?",
			"Do you really want to quit?",
			"Are you not sure you do not want to not quit the game?",
			"(\"&#(!% (\"!/$!)\\ =!)\")",
			"Environment.Exit(0);",
			"The \"yes\" and \"no\" buttons on this prompt are reversed.",
			"Delete all your save files?",
			"Delete system32?",
			"      Yes. No.",
			"      No. Yes.",
			"         What?",
		};

		public override void Load() {
			FMLDocument Doc = new FMLDocument();
			Doc.TagSet.AddTags("window", "button", "label");
			FML.Parse("content/gui/main_menu.fml", Doc);

		}

		public override void DrawGUI(float Dt) {
			base.DrawGUI(Dt);

			//Gfx.Clear(new Color(100, 100, 100, 0));
			/*Gfx.Line(new Vertex2(new Vector2(0, 0), Color.Red), new Vertex2(new Vector2(100, -100), Color.Red), 10);

			Txt.Draw();*/
		}
	}
}