using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ankama.Animator2D.Sources.Rendering.CustomPasses
{

[Serializable]
public class AddOutlinesPassSettings
{
	public int shaderAddOutlinesPassIndex;

	public Color outlineColor;

	public float outlineWidth;
	
	public AddOutlinesPassSettings()
	{
		outlineWidth = 1.0f;
        outlineColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        shaderAddOutlinesPassIndex = 0;

		// Todo : Ankama.Logging.Log$$Initialize(param_1);
	}
}
}
