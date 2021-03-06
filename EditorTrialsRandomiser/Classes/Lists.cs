﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTrialsRandomiser.Classes
{
    public static class Lists
    {
        public static List<string> vegas = new List<string> {
   "Vegas - 360° Stabilization",
   "Vegas - Add Noise",
   "Vegas - AutoLooks",
   "Vegas - Bézier Masking",
   "Vegas - Black and White",
   "Vegas - Black Restore",
   "Vegas - Border",
   "Vegas - Brightness and Contrast",
   "Vegas - Broadcast Colors",
   "Vegas - Bump Map",
   "Vegas - Channel Blend",
   "Vegas - Chroma Blur",
   "Vegas - Chroma Keyer",
   "Vegas - Color Balance",
   "Vegas - Color Corrector",
   "Vegas - Color Corrector (Secondary)",
   "Vegas - Color Curves",
   "Vegas - Color Match",
   "Vegas - Convolution Kernel",
   "Vegas - Cookie Cutter",
   "Vegas - Crop",
   "Vegas - Defocus",
   "Vegas - Deform",
   "Vegas - Dual Fish Eye Stitching",
   "Vegas - Fill Light",
   "Vegas - Film Effects",
   "Vegas - Film Grain",
   "Vegas - Gaussian Blur",
   "Vegas - Glint",
   "Vegas - Glow",
   "Vegas - Gradient Map",
   "Vegas - HSL Adjust",
   "Vegas - Invert",
   "Vegas - LAB Adjust",
   "Vegas - Layer Dimensionality",
   "Vegas - Lens Flare",
   "Vegas - Levels",
   "Vegas - Light Rays",
   "Vegas - Linear Blur",
   "Vegas - LUT Filter",
   "Vegas - Mask Generator",
   "Vegas - Median",
   "Vegas - Min and Max",
   "Vegas - Mirror",
   "Vegas - Newsprint",
   "Vegas - Picture In Picture",
   "Vegas - Pinch/Punch",
   "Vegas - Pixelate",
   "Vegas - Quick Blur",
   "Vegas - Radial Blur",
   "Vegas - Radial Pixelate",
   "Vegas - Rays",
   "Vegas - Saturation Adjust",
   "Vegas - Scene Rotation",
   "Vegas - Sepia",
   "Vegas - Sharpen",
   "Vegas - Smart Upscale",
   "Vegas - Smart Zoom",
   "Vegas - Soft Contrast",
   "Vegas - Spherize",
   "Vegas - Starburst",
   "Vegas - Stereoscopic 3D Adjust",
   "Vegas - Swirl",
   "Vegas - Threshold",
   "Vegas - Timecode",
   "Vegas - Tiny Planet",
   "Vegas - TV Simulator",
   "Vegas - Unsharp Mask",
   "Vegas - Video Stabilization",
   "Vegas - Vignette",
   "Vegas - Wave",
   "Vegas - White Balance"
  };

        public static List<string> ae = new List<string> {
   "AE - Audio - Backwards",
   "AE - Audio - Bass & Treble",
   "AE - Audio - Delay",
   "AE - Audio - Flange & Chorus",
   "AE - Audio - High-Low Pass",
   "AE - Audio - Modulator",
   "AE - Audio - Parametric EQ",
   "AE - Audio - Reverb",
   "AE - Audio - Stereo Mixer",
   "AE - Audio - Tone",
   "AE - Bilateral Blur",
   "AE - Camera Lens Blur",
   "AE - Camera-Shake Deblur",
   "AE - CC Cross Blur",
   "AE - CC Radial Blur",
   "AE - CC Radial Fast Blur",
   "AE - CC Vector Blur",
   "AE - Channel Blur",
   "AE - Compound Blur",
   "AE - Directional Blur",
   "AE - Fast Box Blur",
   "AE - Gaussian Blur",
   "AE - Radial Blur",
   "AE - Sharpen",
   "AE - Smart Blur",
   "AE - Unsharp Mask",
   "AE - Arithmetic",
   "AE - Blend",
   "AE - Calculations",
   "AE - CC Composite",
   "AE - Channel Combiner",
   "AE - Compound Arithmetic",
   "AE - Invert",
   "AE - Minimax",
   "AE - Remove Color Matting",
   "AE - Set Channels",
   "AE - Set Matte",
   "AE - Shift Channels",
   "AE - Solid Composite",
   "AE - CINEWARE",
   "AE - Auto Color",
   "AE - Auto Contrast",
   "AE - Auto Levels",
   "AE - Black & White",
   "AE - Brightness & Contrast",
   "AE - Broadcast Colors",
   "AE - CC Color Neutralizer",
   "AE - CC Color Offset",
   "AE - CC Kernel",
   "AE - CC Toner",
   "AE - Change Color",
   "AE - Change to Color",
   "AE - Channel Mixer",
   "AE - Color Balence",
   "AE - Color Balence (HLS)",
   "AE - Color Link",
   "AE - Color Stabilizer",
   "AE - Colorama",
   "AE - Curves",
   "AE - Equalize",
   "AE - Exposure",
   "AE - Gamma/Pedestal/Gain",
   "AE - Hue/Saturation",
   "AE - Leave Color",
   "AE - Levels",
   "AE - Levels (Individual Controls)",
   "AE - Lumetri Color",
   "AE - Photo Filter",
   "AE - PS Arbitrary Map",
   "AE - Selective Color",
   "AE - Shadow/Highlight",
   "AE - Tint",
   "AE - Tritone",
   "AE - Vibrance",
   "AE - Video Limiter",
   "AE - Bezier Warp",
   "AE - Bulge",
   "AE - CC Bend It",
   "AE - CC Bender",
   "AE - CC Blobbylize",
   "AE - CC Flo Motion",
   "AE - CC Griddler",
   "AE - CC Lens",
   "AE - CC Page Turn",
   "AE - CC Power Pin",
   "AE - CC Ripple Pulse",
   "AE - CC Slant",
   "AE - CC Smear",
   "AE - CC Split",
   "AE - CC Split 2",
   "AE - CC Tiler",
   "AE - Corner Pin",
   "AE - Detail-Preserving Upscale",
   "AE - Displacement Map",
   "AE - Liquify",
   "AE - Magnify",
   "AE - Mesh Warp",
   "AE - Mirror",
   "AE - Offset",
   "AE - Optics Compensation",
   "AE - Polar Coordninates",
   "AE - Reshape",
   "AE - Ripple",
   "AE - Rolling Shutter Repair",
   "AE - Smear",
   "AE - Spherize",
   "AE - Transform",
   "AE - Turbulent Displace",
   "AE - Twirl",
   "AE - Warp",
   "AE - Warp Stabilizer",
   "AE - Wave Warp",
   "AE - 4-Color Gradient",
   "AE - Advanced Lightning",
   "AE - Audio Spectrum",
   "AE - Audio Waveform",
   "AE - Beam",
   "AE - CC Glue Gun",
   "AE - CC Light Burst 2.5",
   "AE - Light Rays",
   "AE - Light Sweep",
   "AE - CC Threads",
   "AE - Cell Pattern",
   "AE - Checkerboard",
   "AE - Circle",
   "AE - Ellipse",
   "AE - Eyedropper Fill",
   "AE - Fill",
   "AE - Fractal",
   "AE - Gradient Ramp",
   "AE - Grid",
   "AE - Lens Flare",
   "AE - Paint Bucket",
   "AE - Radio Waves",
   "AE - Scribble",
   "AE - Stroke",
   "AE - Vegas",
   "AE - Write-on",
   "AE - VR Blur",
   "AE - VR Chromatic Aberrations",
   "AE - VR Color Gradients",
   "AE - VR Converter",
   "AE - VR De-Noise",
   "AE - VR Digital Glitch",
   "AE - VR Fractal Noise",
   "AE - VR Glow",
   "AE - VR Plane to Sphere",
   "AE - VR Rotate Sphere",
   "AE - VR Sharpen",
   "AE - VR Sphere to Plane",
   "AE - Advanced Spill Suppressor",
   "AE - CC Simple Wire Removal",
   "AE - Color Difference Key",
   "AE - Color Range",
   "AE - Difference Matte",
   "AE - Extract",
   "AE - Inner/Outer Key",
   "AE - Key Cleaner",
   "AE - Keylight (1.2)",
   "AE - Linear Color Key",
   "AE - Add Grain",
   "AE - Dust & Scratches",
   "AE - Fractal Noise",
   "AE - Match Grain",
   "AE - Median",
   "AE - Median (Legacy",
   "AE - Noise",
   "AE - Noise Alpha",
   "AE - Noise HLS",
   "AE - Noise HLS Auto",
   "AE - Remove Grain",
   "AE - Turbulent Noise",
   "AE - Basic 3D",
   "AE - Basic Text",
   "AE - Color Key",
   "AE - Gaussian Blur (Legacy)",
   "AE - Lightning",
   "AE - Luma Key",
   "AE - Path Text",
   "AE - Reduce Interlace Flicker",
   "AE - Spill Suppressor",
   "AE - 3D Camera Tracker",
   "AE - 3D Glasses",
   "AE - Bevel Alpha",
   "AE - Bevel Edges",
   "AE - CC Cylinder",
   "AE - CC Environment",
   "AE - CC Sphere",
   "AE - CC Spotlight",
   "AE - Drop Shadow",
   "AE - Radial Shadow",
   "AE - Card Dance",
   "AE - Caustics",
   "AE - CC Ball Action",
   "AE - CC Bubbles",
   "AE - CC Drizzle",
   "AE - CC Hair",
   "AE - CC Mr. Mercury",
   "AE - CC Particle Systems II",
   "AE - CC Particle World",
   "AE - CC Pixel Polly",
   "AE - CC Rainfall",
   "AE - CC Scatterize",
   "AE - CC Snowfall",
   "AE - CC Star Burst",
   "AE - Foam",
   "AE - Particle Playground",
   "AE - Shatter",
   "AE - Wave World",
   "AE - Brush Strokes",
   "AE - Cartoon",
   "AE - CC Block Load",
   "AE - CC Burn Film",
   "AE - CC Glass",
   "AE - CC HexTile",
   "AE - CC Kaleida",
   "AE - CC Mr. Smoothie",
   "AE - CC Plastic",
   "AE - CC RepeTile",
   "AE - CC Threshold",
   "AE - CC Threshold RGB",
   "AE - CC Vignette",
   "AE - Color Emboss",
   "AE - Emboss",
   "AE - Find Edges",
   "AE - Glow",
   "AE - Mosaic",
   "AE - Motion Tile",
   "AE - Posterize",
   "AE - Roughen Edges",
   "AE - Scatter",
   "AE - Strobe Light",
   "AE - Texturize",
   "AE - Threshold",
   "AE - Numbers",
   "AE - Timecode",
   "AE - CC Force Motion Blur",
   "AE - CC Wide Time",
   "AE - Echo",
   "AE - Pixel Motion Blur",
   "AE - Posterize Time",
   "AE - Time Difference",
   "AE - Time Displacement",
   "AE - Timewarp",
   "AE - Block Dissolve",
   "AE - Card Wipe",
   "AE - CC Glass Wipe",
   "AE - CC Grid Wipe",
   "AE - CC Image Wipe",
   "AE - CC Jaws",
   "AE - CC Light Wipe",
   "AE - CC Line Sweep",
   "AE - CC Radial ScaleWipe",
   "AE - CC Scale Wipe",
   "AE - CC Twister",
   "AE - CC WarpoMatic",
   "AE - Gradient Wipe",
   "AE - Iris Wipe",
   "AE - Linear Wipe",
   "AE - Radial Wipe",
   "AE - Venetian Blinds"
  };

        public static List<string> reVision = new List<string> {
   "RE:Vision DE:Noise",
   "RE:Vision DE:Noise Frame Average",
   "RE:Vision DEFlicker Auto Levels",
   "RE:Vision DEFlicker High Speed",
   "RE:Vision DEFlicker Time Lapse",
   "RE:Vision FieldsKit Deinterlacer",
   "RE:Vision FieldsKit Pulldown",
   "RE:Vision FieldsKit Reinterlacer",
   "RE:Vision Motion Vectors: Create",
   "RE:Vision PV Feather",
   "RE:Vision RE:FILL Alpha",
   "RE:Vision RE:FILL Area Fill",
   "RE:Vision RE:FILL Choke",
   "RE:Vision RE:FILL Frame Borders",
   "RE:Vision RE:FILL GrowShrink",
   "RE:Vision RE:FILL Offset",
   "RE:Vision RE:Flex Morph",
   "RE:Vision RE:Flex Motion Morph",
   "RE:Vision RE:Flex Warp",
   "RE:Vision RE:Lens Chromatic Aberration",
   "RE:Vision RE:Lens Curved Mirrors",
   "RE:Vision RE:Lens Defish",
   "RE:Vision RE:Lens From LatLong",
   "RE:Vision RE:Lens Reframe",
   "RE:Vision RE:Lens Set Bounds",
   "RE:Vision RE:Lens Superfish",
   "RE:Vision RE:Lens To LatLong",
   "RE:Vision RE:Map Displace",
   "RE:Vision RE:Map Distort",
   "RE:Vision RE:Map Inverse UV",
   "RE:Vision RE:Map Planar",
   "RE:Vision RE:Map UV",
   "RE:Vision RE:Match Basic",
   "RE:Vision RE:Match Color",
   "RE:Vision RE:Match Stereo",
   "RE:Vision RSMB",
   "RE:Vision RSMB Pro",
   "RE:Vision RSMB Pro Vectors",
   "RE:Vision Shade Normals",
   "RE:Vision Shade Shape",
   "RE:Vision SK Diffusion",
   "RE:Vision SK Directional Per Pixel",
   "RE:Vision SK Directional With Splines",
   "RE:Vision SK Frame Accumulate",
   "RE:Vision SK Gaussian",
   "RE:Vision SK Gaussian Per Pixel",
   "RE:Vision SK Sharpen",
   "RE:Vision SK Staircase Suppress",
   "RE:Vision SK ZBlur",
   "RE:Vision Twixtor",
   "RE:Vision Twixtor Pro",
   "RE:Vision Twixtor Pro, Vectors In",
   "RE:Vision Video Gogh",
   "RE:Vision Video Gogh Pro"
  };

        public static List<string> sapphire = new List<string> {
   "Sapphire S_ChannelSwitcher",
   "Sapphire S_ClampChroma",
   "Sapphire S_DuoTone",
   "Sapphire S_Gamma",
   "Sapphire S_Hotspots",
   "Sapphire S_HueSatBright",
   "Sapphire S_Invert",
   "Sapphire S_Monochrome",
   "Sapphire S_QuadTone",
   "Sapphire S_ShowBadColors",
   "Sapphire S_Threshold",
   "Sapphire S_Tint",
   "Sapphire S_TriTone",
   "Sapphire S_Beauty",
   "Sapphire S_Blur",
   "Sapphire S_BlurChannels",
   "Sapphire S_BlurChroma",
   "Sapphire S_BlurDirectional",
   "Sapphire S_BlurMoCurves",
   "Sapphire S_BlurMotion",
   "Sapphire S_Convolve",
   "Sapphire S_ConvolveComp",
   "Sapphire S_Deband",
   "Sapphire S_DefocusPrism",
   "Sapphire S_EdgeAwareBlur",
   "Sapphire S_EdgeBlur",
   "Sapphire S_GrainRemove",
   "Sapphire S_Median",
   "Sapphire S_RackDefocus",
   "Sapphire S_RackDfComp",
   "Sapphire S_Sharpen",
   "Sapphire S_SoftFocus",
   "Sapphire S_ZBlur",
   "Sapphire S_ZConvolve",
   "Sapphire S_ZDefocus",
   "Sapphire S_Effect",
   "Sapphire S_Transition",
   "Sapphire S_EdgeFlash",
   "Sapphire S_Layer",
   "Sapphire S_MathOps",
   "Sapphire S_MatteOps",
   "Sapphire S_MatteOpsComp",
   "Sapphire S_ZComp",
   "Sapphire S_Distort",
   "Sapphire S_DistortBlur",
   "Sapphire S_DistortChroma",
   "Sapphire S_DistortRGB",
   "Sapphire S_InfiniteZoom",
   "Sapphire S_ParallaxStrips",
   "Sapphire S_Shake",
   "Sapphire S_StretchFrameEdges",
   "Sapphire S_WarpBubble",
   "Sapphire S_WarpBubble2",
   "Sapphire S_WarpChroma",
   "Sapphire S_WarpCornerPin",
   "Sapphire S_WarpDrops",
   "Sapphire S_WarpFishEye",
   "Sapphire S_WarpMagnify",
   "Sapphire S_WarpPerspective",
   "Sapphire S_WarpPolar",
   "Sapphire S_WarpPuddle",
   "Sapphire S_WarpPuff",
   "Sapphire S_WarpRepeat",
   "Sapphire S_WarpTransform",
   "Sapphire S_WarpVortex",
   "Sapphire S_WarpWaves",
   "Sapphire S_WarpWaves2",
   "Sapphire S_BokehLights",
   "Sapphire S_DropShadow",
   "Sapphire S_EdgeRays",
   "Sapphire S_Flashbulbs",
   "Sapphire S_Glare",
   "Sapphire S_Glint",
   "Sapphire S_GlintRainbow",
   "Sapphire S_Glow",
   "Sapphire S_GlowAura",
   "Sapphire S_GlowDarks",
   "Sapphire S_GlowDist",
   "Sapphire S_GlowEdges",
   "Sapphire S_GlowNoise",
   "Sapphire S_GlowOrthicon",
   "Sapphire S_GlowRainbow",
   "Sapphire S_GlowRings",
   "Sapphire S_LensFlare",
   "Sapphire S_LensFlareAutoTrack",
   "Sapphire S_Light3D",
   "Sapphire S_LightLeak",
   "Sapphire S_Rays",
   "Sapphire S_SpotLight",
   "Sapphire S_Streaks",
   "Sapphire S_ZGlow",
   "Sapphire S_Aurora",
   "Sapphire S_Caustics",
   "Sapphire S_Clouds",
   "Sapphire S_CloudsColorSmooth",
   "Sapphire S_CloudsMultColor",
   "Sapphire S_CloudsPerspective",
   "Sapphire S_CloudsPsyko",
   "Sapphire S_CloudsVortex",
   "Sapphire S_Gradient",
   "Sapphire S_GradientMulti",
   "Sapphire S_GradientRadial",
   "Sapphire S_Grid",
   "Sapphire S_Grunge",
   "Sapphire S_LaserBeam",
   "Sapphire S_Luna",
   "Sapphire S_MuzzleFlash",
   "Sapphire S_NightSky",
   "Sapphire S_Shape",
   "Sapphire S_Sparkles",
   "Sapphire S_SparklesColor",
   "Sapphire S_TextureCells",
   "Sapphire S_TextureChromaSpiral",
   "Sapphire S_TextureFlux",
   "Sapphire S_TextureFolded",
   "Sapphire S_TextureLoops",
   "Sapphire S_TextureMicro",
   "Sapphire S_TextureMoire",
   "Sapphire S_TextureNeurons",
   "Sapphire S_TextureNoiseEmboss",
   "Sapphire S_TextureNoisePaint",
   "Sapphire S_TexturePlasma",
   "Sapphire S_TextureSpots",
   "Sapphire S_TextureTiles",
   "Sapphire S_TextureWeave",
   "Sapphire S_Zap",
   "Sapphire S_ZapFrom",
   "Sapphire S_ZapTo",
   "Sapphire S_AutoPaint",
   "Sapphire S_BandPass",
   "Sapphire S_BleachBypass",
   "Sapphire S_Brush",
   "Sapphire S_Cartoon",
   "Sapphire S_CartoonPaint",
   "Sapphire S_CrossHatch",
   "Sapphire S_Diffuse",
   "Sapphire S_DigitalDamage",
   "Sapphire S_DogVision",
   "Sapphire S_EdgeColorize",
   "Sapphire S_EdgeDetect",
   "Sapphire S_EdgeDetectDouble",
   "Sapphire S_EdgesInDirection",
   "Sapphire S_Emboss",
   "Sapphire S_EmbossDistort",
   "Sapphire S_EmbossGlass",
   "Sapphire S_EmbossShiny",
   "Sapphire S_Etching",
   "Sapphire S_FilmDamage",
   "Sapphire S_FilmEffect",
   "Sapphire S_FlysEyeCircles",
   "Sapphire S_FlysEyeHex",
   "Sapphire S_FlysEyeHect",
   "Sapphire S_Grain",
   "Sapphire S_GrainStatic",
   "Sapphire S_HalfTone",
   "Sapphire S_HalfToneColor",
   "Sapphire S_HalfToneRings",
   "Sapphire S_JpegDamage",
   "Sapphire S_Kaleido",
   "Sapphire S_KaleidoPolar",
   "Sapphire S_KaleidoRadial",
   "Sapphire S_Mosaic",
   "Sapphire S_PixelSort",
   "Sapphire S_Posterize",
   "Sapphire S_PseudoColor",
   "Sapphire S_PsykoBlobs",
   "Sapphire S_PsykoStripes",
   "Sapphire S_RomanTile",
   "Sapphire S_ScanLines",
   "Sapphire S_ScanLinesMono",
   "Sapphire S_Sketch",
   "Sapphire S_Solarize",
   "Sapphire S_StripSlide",
   "Sapphire S_TileScramble",
   "Sapphire S_TVDamage",
   "Sapphire S_Vignette",
   "Sapphire S_VintageColor2Strip",
   "Sapphire S_VintageColor3Strip",
   "Sapphire S_Zebrafy",
   "Sapphire S_ZebrafyColor",
   "Sapphire S_ZFogExponential",
   "Sapphire S_ZFogLinear",
   "Sapphire S_CutToDissolve",
   "Sapphire S_Feedback",
   "Sapphire S_FeedbackBubble",
   "Sapphire S_FeedbackDistort",
   "Sapphire S_FieldRemove",
   "Sapphire S_Flicker",
   "Sapphire S_FlickerMatch",
   "Sapphire S_FlickerMatchColor",
   "Sapphire S_FlickerMatchMatte",
   "Sapphire S_FlickerMchMatteColor",
   "Sapphire S_FlickerRemove",
   "Sapphire S_FlickerRemoveColor",
   "Sapphire S_FlickerRemoveMatte",
   "Sapphire S_FlickerRmMatteColor",
   "Sapphire S_FreezeFrame",
   "Sapphire S_GetFrame",
   "Sapphire S_JitterFrames",
   "Sapphire S_MotionDetect",
   "Sapphire S_NearestColor",
   "Sapphire S_RandomEdits",
   "Sapphire S_RepairFrames",
   "Sapphire S_Retime",
   "Sapphire S_ReverseClip",
   "Sapphire S_ReverseEdits",
   "Sapphire S_TimeAverage",
   "Sapphire S_TimeDisplace",
   "Sapphire S_TimeSlice",
   "Sapphire S_TimeWarpRGB",
   "Sapphire S_Trails",
   "Sapphire S_TrailsDiffuse",
   "Sapphire S_CardFlip",
   "Sapphire S_Dissolve",
   "Sapphire S_DissolveAutoPaint",
   "Sapphire S_DissolveBlur",
   "Sapphire S_DissolveBubble",
   "Sapphire S_DissolveDefocus",
   "Sapphire S_DissolveDiffuse",
   "Sapphire S_DissolveDigitalDamage",
   "Sapphire S_DissolveDistort",
   "Sapphire S_DissolveEdgeRays",
   "Sapphire S_DissolveFilm",
   "Sapphire S_DissolveFlashbulbs",
   "Sapphire S_DissolveGlare",
   "Sapphire S_DissolveGlintRainbow",
   "Sapphire S_DissolveGlow",
   "Sapphire S_DissolveLensFlare",
   "Sapphire S_DissolveLuma",
   "Sapphire S_DissolvePixelSort",
   "Sapphire S_DissolvePuddle",
   "Sapphire S_DissolveRays",
   "Sapphire S_DissolveShake",
   "Sapphire S_DissolveSpeckle",
   "Sapphire S_DissolveStatic",
   "Sapphire S_DissolveTiles",
   "Sapphire S_DissolveVortex",
   "Sapphire S_DissolveWaves",
   "Sapphire S_DissolveZap",
   "Sapphire S_FilmRoll",
   "Sapphire S_FlutterCut",
   "Sapphire S_ParallaxStripsTransition",
   "Sapphire S_StripSlideTransition",
   "Sapphire S_Swish3D",
   "Sapphire S_SwishPan",
   "Sapphire S_TVChannelChange",
   "Sapphire S_WhipLash",
   "Sapphire S_WipeBlobs",
   "Sapphire S_WipeBubble",
   "Sapphire S_WipeCells",
   "Sapphire S_WipeChecker",
   "Sapphire S_WipeCircle",
   "Sapphire S_WipeClock",
   "Sapphire S_WipeClouds",
   "Sapphire S_WipeDiffuse",
   "Sapphire S_WipeDots",
   "Sapphire S_WipeDoubleWedge",
   "Sapphire S_WipeFlux",
   "Sapphire S_WipeFourWedges",
   "Sapphire S_WipeLine",
   "Sapphire S_WipeMoire",
   "Sapphire S_WipePixelate",
   "Sapphire S_WipePlasma",
   "Sapphire S_WipePointalize",
   "Sapphire S_WipeRectangle",
   "Sapphire S_WipeRings",
   "Sapphire S_WipeStar",
   "Sapphire S_WipeStripes",
   "Sapphire S_WipeTiles",
   "Sapphire S_WipeWeave",
   "Sapphire S_WipeWedge"
  };

        public static List<string> bcc = new List<string> {
   "BCC Extruded EPS",
   "BCC Extruded Spline",
   "BCC Extruded Text",
   "BCC Layer Deformer",
   "BCC Title Studio",
   "BCC Type On Text",
   "BCC Artist's Poster",
   "BCC Bump Map",
   "BCC Cartoon Look",
   "BCC Cartooner",
   "BCC Charcoal Sketch",
   "BCC Halftone",
   "BCC Median",
   "BCC Pencil Sketch",
   "BCC Posterize",
   "BCC Spray Paint Noise",
   "BCC Tile Mosaic",
   "BCC Water Color",
   "BCC Directional Blur",
   "BCC Fast Lens Blur",
   "BCC Gaussian Blur",
   "BCC Lens Shape",
   "BCC Motion Blur",
   "BCC Pyramid Blur",
   "BCC Radial Blur",
   "BCC Spiral Blur",
   "BCC Unsharp Mask",
   "BCC Z-Blur",
   "BCC 3 Way Color Grade",
   "BCC Brightness-Contrast",
   "BCC Color Balence",
   "BCC Color Correction",
   "BCC Color Match",
   "BCC Colorize",
   "BCC Correct Selected Color",
   "BCC Hue-Sat-Lightness",
   "BCC Invert Solarize",
   "BCC Levels Gamma",
   "BCC MultiTone Mix",
   "BCC Tritone",
   "BCC Videoscope",
   "BCC Deinterlace",
   "BCC Fast Film Glow",
   "BCC Fast Film Process",
   "BCC Film Damage",
   "BCC Film Grain",
   "BCC Match Grain",
   "BCC Two Strip Color",
   "BCC Vignette",
   "BCC Beauty Studio",
   "BCC Broadcast Safe",
   "BCC Dropout Fixer",
   "BCC Dust and Scratches",
   "BCC DV Fixer",
   "BCC Flicker Fixer",
   "BCC Lens Correction",
   "BCC Magic Sharp",
   "BCC Motion Key",
   "BCC Noise Reduction",
   "BCC Optical Stabilizer",
   "BCC Pixel Fixer",
   "BCC Reframer",
   "BCC Remover",
   "BCC UpRez",
   "BCC Wire Remover",
   "BCC Alpha Process",
   "BCC Chroma Key",
   "BCC Chroma Key Studio",
   "BCC Composite",
   "BCC Composite Choker",
   "BCC Light Warp",
   "BCC Linear Color key",
   "BCC Linear Luma Key",
   "BCC Make Alpha Key",
   "BCC Matte Choker",
   "BCC Matte Cleanup",
   "BCC Pixel Chooser",
   "BCC Premult",
   "BCC Primatte Studio",
   "BCC RGB Blend",
   "BCC Spill Remover",
   "BCC Two Way Key",
   "BCC Edge Lighting",
   "BCC Glare",
   "BCC Glint",
   "BCC Glitter",
   "BCC Laser Beam",
   "BCC Lens Flare 3D",
   "BCC Light Leaks",
   "BCC Light Sweep",
   "BCC Lightning",
   "BCC Rays Cartoon",
   "BCC Rays Puffy",
   "BCC Rays Radiant Edges",
   "BCC Rays Radiant Spotlight",
   "BCC Rays Ring",
   "BCC Rays Ripply",
   "BCC Rays Streaky",
   "BCC Rays Textured",
   "BCC Rays Wedge",
   "BCC Reverse Spotlight",
   "BCC Spotlight",
   "BCC Stage Light",
   "BCC Corner Pin",
   "BCC Match Move",
   "BCC WitnessProtection",
   "BCC Alpha Pixel Noise OBS",
   "BCC Alpha Spotlight OBS",
   "BCC Boost Blend OBS",
   "BCC Color Palette OBS",
   "BCC DeGrain OBS",
   "BCC DeNoise OBS",
   "BCC Film Glow Dissolve OBS",
   "BCC Film Glow OBS",
   "BCC Film Process OBS",
   "BCC Fire OBS",
   "BCC Glow Matte OBS",
   "BCC Glow OBS",
   "BCC Lens Blur OBS",
   "BCC Lens Flare Adv OBS",
   "BCC Lens Flare OBS",
   "BCC Lens Transition OBS",
   "BCC Light Matte OBS",
   "BCC Light Zoom OBS",
   "BCC Noise Map OBS",
   "BCC Rough Glow OBS",
   "BCC Safe Colors OBS",
   "BCC Sequencer OBS",
   "BCC Smooth Tone OBS",
   "BCC Star Matte OBS",
   "BCC Super Blend OBS",
   "BCC Z Space I OBS",
   "BCC Z Space II OBS",
   "BCC Z Space III OBS",
   "BCC 2D Particles",
   "BCC Comet",
   "BCC Organic Strands",
   "BCC Particle Array 3D",
   "BCC Particle Emitter 3D",
   "BCC Particle Illusion",
   "BCC Particle System",
   "BCC Pin Art 3D",
   "BCC Rain",
   "BCC Snow",
   "BCC Sparks",
   "BCC Wild Cards",
   "BCC 3D Extruded Image Shatter",
   "BCC 3D Image Shatter",
   "BCC Cube",
   "BCC Cylinder",
   "BCC DVE",
   "BCC DVE Basic",
   "BCC Fast Flipper",
   "BCC Page Turn",
   "BCC Pan and Zoom",
   "BCC Sphere",
   "BCC Sphere Transition",
   "BCC Color Choker",
   "BCC Colorize Glow",
   "BCC Damaged TV",
   "BCC Drop Shadow",
   "BCC Edge Grunge",
   "BCC Emboss",
   "BCC Glow Alpha Edges",
   "BCC Grunge",
   "BCC LED",
   "BCC Misalignment",
   "BCC Mosaic",
   "BCC Multi Shadow",
   "BCC Prism",
   "BCC RGB Edges",
   "BCC RGB Pixel Noise",
   "BCC Scanline",
   "BCC Scatterize",
   "BCC Video Glitch",
   "BCC Brick",
   "BCC Caustics",
   "BCC Cloth",
   "BCC Clouds",
   "BCC Fractal Noise",
   "BCC Granite",
   "BCC Mixed Colors",
   "BCC Noise Map 2",
   "BCC Rays",
   "BCC Reptilian",
   "BCC Rock",
   "BCC Stars",
   "BCC Steel Plate",
   "BCC Veined Marble",
   "BCC Weave",
   "BCC Wood Grain",
   "BCC Wooden Planks",
   "BCC Beat Reactor",
   "BCC Jitter",
   "BCC Jitter Basic",
   "BCC Looper",
   "BCC Optical Flow",
   "BCC Posterize Time",
   "BCC Temporal Blur",
   "BCC Time Displacement",
   "BCC Trails",
   "BCC Trails Basic",
   "BCC Velocity Remap",
   "BCC Blobs Wipe",
   "BCC Blur Dissolve",
   "BCC Burnt Film",
   "BCC Checker Wipe",
   "BCC Composite Dissolve",
   "BCC Criss-Cross Wipe",
   "BCC Cross Glitch",
   "BCC Cross Melt",
   "BCC Cross Zoom",
   "BCC Damaged TV Dissolve",
   "BCC Fast Film Glow Dissolve",
   "BCC Flutter Cut",
   "BCC Grid Wipe",
   "BCC Lens Blur Dissolve",
   "BCC Lens Distortion Wipe",
   "BCC Lens Flare Dissolve",
   "BCC Lens Flare Round",
   "BCC Lens Flare Spiked",
   "BCC Lens Flash",
   "BCC Light Leaks Dissolve",
   "BCC Light Wipe",
   "BCC Linear Wipe",
   "BCC Multi Stretch Wipe",
   "BCC Multi Stripe Wipe",
   "BCC Particle Illusion Dissolve",
   "BCC Radial Wipe",
   "BCC Rays Dissolve",
   "BCC Rectangular Wipe",
   "BCC Ribbon Wipe",
   "BCC Rings Wipe",
   "BCC Ripple Dissolve",
   "BCC Swish Pan",
   "BCC Textured Pan",
   "BCC Tile Wipe",
   "BCC Tritone Dissolve",
   "BCC Twister",
   "BCC Vector Blur Dissolve",
   "BCC Vignette Wipe",
   "BCC Water Waves Dissolve",
   "BCC VR Blur",
   "BCC VR Flicker Fixer",
   "BCC VR Insert",
   "BCC VR Reorient",
   "BCC VR Sharpen",
   "BCC Bulge",
   "BCC Displacement Map",
   "BCC Morph",
   "BCC Polar Displacement",
   "BCC Ripple",
   "BCC Turbulence",
   "BCC Twirl",
   "BCC Vector Displacement",
   "BCC Video Morph",
   "BCC Warp",
   "BCC Wave"
  };

        public static List<string> digiEffects = new List<string> {
   "Digieffects ChannelNoise",
   "Digieffects ChannelRange",
   "Digieffects Colorize",
   "Digieffects Edgex",
   "Digieffects Glow",
   "Digieffects GradientDesigner",
   "Digieffects Grayscaler",
   "Digieffects LightWrap",
   "Digieffects NightBloom",
   "Digieffects Solarize",
   "Digieffects SpecularLighting",
   "Digieffects AgedFilm",
   "Digieffects Artifact",
   "Digieffects Blockade",
   "Digieffects ChannelOffset",
   "Digieffects Destabilize",
   "Digieffects Interference",
   "Digieffects OverExpose",
   "Digieffects Skew",
   "Digieffects WaveDisplace",
   "Digieffects Bubbles",
   "Digieffects ElectricalArcs",
   "Digieffects FairyDust",
   "Digieffects Fire",
   "Digieffects FireWorks",
   "Digieffects FogFactory",
   "Digieffects MuzzleFlash",
   "Digieffects RainFall",
   "Digieffects Smoke",
   "Digieffects SnowStorm",
   "Digieffects Sparks",
   "Digieffects CrazyStripes",
   "Digieffects Crystallizer",
   "Digieffects HyperHarmonizer",
   "Digieffects Newsprint",
   "Digieffects Nexus",
   "Digieffects Perspection",
   "Digieffects SchematicGrids",
   "Digieffects Stargate",
   "Digieffects VanGoghist",
   "Digieffects VisualHarmonizer"
  };

        public static List<string> rgTrapcode = new List<string> {
   "RG Trapcode 3D Stroke",
   "RG Trapcode Echospace",
   "RG Trapcode Form",
   "RG Trapcode Horizon",
   "RG Trapcode Lux",
   "RG Trapcode Mir 3",
   "RG Trapcode Particular",
   "RG Trapcode Shine",
   "RG Trapcode Sound Keys",
   "RG Trapcode Starglow",
   "RG Trapcode Tao"
  };

        public static List<string> rgMagicBullet = new List<string> {
   "RG Magic Bullet Colorista IV",
   "RG Magic Bullet Cosmo II",
   "RG Magic Bullet Denoiser III",
   "RG Magic Bullet Film",
   "RG Magic Bullet Looks",
   "RG Magic Bullet Mojo II",
   "RG Magic Bullet Renoiser"
  };

        public static List<string> rgUniverse = new List<string> {
   "RG Universe uni.Blur",
   "RG Universe uni.Compound Blur",
   "RG Universe uni.Spot Blur",
   "RG Universe uni.Chromatic Aberration",
   "RG Universe uni.Heatwave",
   "RG Universe uni.Prism Displacement",
   "RG Universe uni.RGB Separation",
   "RG Universe uni.Fractal Background",
   "RG Universe uni.Gradient Ramp",
   "RG Universe uni.Soft Gradient Background",
   "RG Universe uni.Spectralicious",
   "RG Universe uni.Turbulence Noise",
   "RG Universe uni.Chromatic Glow",
   "RG Universe uni.Edge Glow",
   "RG Universe uni.Glimmer",
   "RG Universe uni.Glo Fi",
   "RG Universe uni.Glow",
   "RG Universe uni.Point Zoom",
   "RG Universe uni.Array Gun",
   "RG Universe uni.HUD Components",
   "RG Universe uni.Line",
   "RG Universe uni.Logo Motion",
   "RG Universe uni.Progresso",
   "RG Universe uni.AV Club",
   "RG Universe uni.Carousel",
   "RG Universe uni.Ecto",
   "RG Universe uni.Finisher",
   "RG Universe uni.Glitch",
   "RG Universe uni.Glo Fi II",
   "RG Universe uni.Grain16",
   "RG Universe uni.Holomatrix II",
   "RG Universe uni.Knoll Light Factory EZ",
   "RG Universe uni.Long Shadow",
   "RG Universe uni.Luster",
   "RG Universe uni.MisFire",
   "RG Universe uni.Noir Moderne",
   "RG Universe uni.OverLight",
   "RG Universe uni.RetroGrade",
   "RG Universe uni.ShrinkRay",
   "RG Universe uni.Texturize",
   "RG Universe uni.VHS",
   "RG Universe uni.Hacker Text",
   "RG Universe uni.Numbers",
   "RG Universe uni.Screen Text",
   "RG Universe uni.Text Tile",
   "RG Universe uni.Title Motion",
   "RG Universe uni.Type Cast",
   "RG Universe uni.Type On",
   "RG Universe uni.Blinds",
   "RG Universe uni.Camera Shake Transition",
   "RG Universe uni.Carousel Transition",
   "RG Universe uni.Channel Blur",
   "RG Universe uni.Channel Surf",
   "RG Universe uni.Clock Wipe",
   "RG Universe uni.Color Mosaic Transiton",
   "RG Universe uni.Color Stripe",
   "RG Universe uni.Cube",
   "RG Universe uni.Diamond Wave",
   "RG Universe uni.Dolly Fade",
   "RG Universe uni.Exposure Blur",
   "RG Universe uni.Film Transition",
   "RG Universe uni.HalfLight",
   "RG Universe uni.Inside Cube",
   "RG Universe uni.Knoll Light Transition",
   "RG Universe uni.Linear Wipe",
   "RG Universe uni.RetroGrade Transition",
   "RG Universe uni.Rubix Cube",
   "RG Universe uni.Shape Wipe",
   "RG Universe uni.Slide",
   "RG Universe uni.Soft Edge Wipe",
   "RG Universe uni.Spectralicious Transition",
   "RG Universe uni.Swish Pan",
   "RG Universe uni.Triangle Wave",
   "RG Universe uni.Turbulence Transition",
   "RG Universe uni.Unfold",
   "RG Universe uni.VHS Transition",
   "RG Universe uni.Camera Shake",
   "RG Universe uni.Fisheye Fixer",
   "RG Universe uni.Picture in Picture",
   "RG Universe uni.Unmult"
  };

        public static List<string> rgKeying = new List<string> { };

        public static List<string> rgVFX = new List<string> {
   "RG VFX Chromatic Displacement",
   "RG VFX King Pin Tracker",
   "RG VFX Knoll Light Factory",
   "RG VFX Optical Glow",
   "RG VFX Primatte Keyer 6",
   "RG VFX Reflection",
   "RG VFX Shadow",
   "RG VFX Spot Clone Tracker",
   "RG VFX Supercomp"
  };

        public static List<string> ignite = new List<string> {

   "Ignite 360 Animated Lasers",
   "Ignite 360 Blur",
   "Ignite 360 Bulge",
   "Ignite 360 Channel Blur",
   "Ignite 360 Fisheye Converter",
   "Ignite 360 Fractal Noise",
   "Ignite 360 Glow",
   "Ignite 360 Glow Darks",
   "Ignite 360 Lightsword (2-Point Auto)",
   "Ignite 360 Lightsword (4-Point Manual)",
   "Ignite 360 Lightsword (Glow Only)",
   "Ignite 360 Magnify",
   "Ignite 360 Neon Path",
   "Ignite 360 Swirl",
   "Ignite 360 Unsharpen",
   "Ignite 360 Video Transform",
   "Ignite 360 Video Viewer",
   "Ignite Bilateral Blur",
   "Ignite Diffuse",
   "Ignite Lens Blur",
   "Ignite Motion Blur",
   "Ignite Radial Blur",
   "Ignite Zoom Blur",
   "Ignite Channel Blur",
   "Ignite Channel Mixer",
   "Ignite Channel Swapper",
   "Ignite Channel Time Shift",
   "Ignite Auto Color",
   "Ignite Auto Contrast",
   "Ignite Auto Levels",
   "Ignite Color Temperature",
   "Ignite Crush Blacks & Whites",
   "Ignite Custom Gray",
   "Ignite Dehaze",
   "Ignite Exposure Pro",
   "Ignite Hotspots",
   "Ignite Pro Skin Retouch",
   "Ignite White Balence",
   "Ignite Bleach Bypass",
   "Ignite Cine Style",
   "Ignite Color Vibrance",
   "Ignite Day For Night",
   "Ignite Duo Tone",
   "Ignite Grading Transfer",
   "Ignite Hue Colorize",
   "Ignite Hue Shift",
   "Ignite Shadows & Highlights",
   "Ignite Three Strip Color",
   "Ignite Two Strip Color",
   "Ignite Vibrance",
   "Ignite Vignette",
   "Ignite Vignette Exposure",
   "Ignite Block Displacement",
   "Ignite Bulge",
   "Ignite Chromenator",
   "Ignite Derez (VGHS)",
   "Ignite Displacement",
   "Ignite Energy Distortion",
   "Ignite Fluid Distortion",
   "Ignite Heat Distortion",
   "Ignite Insect Vision",
   "Ignite Magnify",
   "Ignite Mosaic",
   "Ignite Smoke Distortion",
   "Ignite Twirl",
   "Ignite Waves",
   "Ignite Witness Protection",
   "Ignite 3D Extrusion",
   "Ignite Animated Lasers",
   "Ignite Audio Spectrum",
   "Ignite Audio Waveform",
   "Ignite Auto Volumetrics",
   "Ignite Caustics",
   "Ignite Clone",
   "Ignite Clouds",
   "Ignite Dimension Rift",
   "Ignite Distance Field",
   "Ignite Drop Shadow",
   "Ignite Fractal Noise",
   "Ignite Grid",
   "Ignite Hyperdrive",
   "Ignite Letterbox",
   "Ignite Lightsword (2-Point Auto)",
   "Ignite Lightsword (4-Point Manual)",
   "Ignite Lightsword (Glow Only)",
   "Ignite Lightsword Ultra (2-Point Auto)",
   "Ignite Lightsword Ultra (4-Point Manual)",
   "Ignite Lightsword Ultra (Glow Only)",
   "Ignite Neon Path",
   "Ignite PiP",
   "Ignite Pond Ripple",
   "Ignite Radio Waves",
   "Ignite Reflection",
   "Ignite Sphere",
   "Ignite Split Screen Masking",
   "Ignite Tile",
   "Ignite Timecode",
   "Ignite 4-Point Color Gradient",
   "Ignite Color Gradient",
   "Ignite Radial Gradient",
   "Ignite Dot Matrix",
   "Ignite Film Damage",
   "Ignite Film Grain",
   "Ignite Flicker",
   "Ignite Grain",
   "Ignite Half Tone",
   "Ignite Half Tone Color",
   "Ignite Jitter",
   "Ignite Lens Dirt",
   "Ignite Noise",
   "Ignite Pixel Sort",
   "Ignite Scan Lines",
   "Ignite Shake",
   "Ignite Stutter",
   "Ignite TV Damage",
   "Ignite Chroma Key",
   "Ignite Chroma UV Blur",
   "Ignite Color Difference Key",
   "Ignite Demult",
   "Ignite Difference Key",
   "Ignite Hue & RGB Key",
   "Ignite Luminance Key",
   "Ignite Anamorphic Lens Flare",
   "Ignite Auto Light Flares",
   "Ignite Gleam",
   "Ignite Glow",
   "Ignite Inner Glow",
   "Ignite Light Flares",
   "Ignite Light Leak",
   "Ignite Light Rays",
   "Ignite Light Streaks",
   "Ignite Neon Glow",
   "Ignite Outer Glow",
   "Ignite Alpha Brightness & Contrast",
   "Ignite Crush Blacks & Whites Alpha",
   "Ignite Erode White",
   "Ignite Invert Alpha",
   "Ignite Light Wrap",
   "Ignite Matte Cleaner",
   "Ignite Remove Color Matting",
   "Ignite Set Matte",
   "Ignite Spill Removal",
   "Ignite Atomic Particle",
   "Ignite Blood Spray",
   "Ignite Fire",
   "Ignite Gunfire",
   "Ignite Lightning & Electricity",
   "Ignite Rain On Glass",
   "Ignite Shatter",
   "Ignite Parallax",
   "Ignite Projector",
   "Ignite Surface Studio",
   "Ignite Cartoon",
   "Ignite Emboss",
   "Ignite Find Edges",
   "Ignite Glow Darks",
   "Ignite Leave Color",
   "Ignite Posterize",
   "Ignite Solarize",
   "Ignite Threshold",
   "Ignite Tint",
   "Ignite Echo",
   "Ignite Motion Trails",
   "Ignite Speed",
   "Ignite Time Displacement",
   "Ignite Time Reverse",
   "Ignite Clone Stamp",
   "Ignite Denoise",
   "Ignite Grain Removal",
   "Ignite Rolling Shutter",
   "Ignite Wire Removal",
   "Ignite Action Cam Crop",
   "Ignite Action Cam Lens Distort",
   "Ignite Bezier Warp",
   "Ignite Lens Distort",
   "Ignite Perspective Warp",
   "Ignite Polar Warp",
   "Ignite Quad Warp",
   "Ignite Spherical Warp",
   "Ignite Vortex Displacement Warp"
  };

        public static List<string> videoCopilot = new List<string> {
   "Video Copilot Element",
   "Video Copilot Optical Flares",
   "Video Copilot Saber",
   "Video Copilot Twitch",
   "Video Copilot VC Color Vibrance"
  };

        public static List<string> omino = new List<string> {
   "omino colorizer",
   "omino diffusion",
   "omino halftone++",
   "omino kaledioscope",
   "omino snake",
   "omino sphere map",
   "omino squares",
   "omino test"
  };

        public static List<string> mettle = new List<string> {
   "Mettle Mantra VR",
   "Mettle Mantra VR Chrome Spheres",
   "Mettle Mantra VR Circular Waves",
   "Mettle Mantra VR Escher Droste",
   "Mettle Mantra VR Graphix",
   "Mettle Mantra VR Hyperbolix",
   "Mettle Mantra VR Magnifying Glass",
   "Mettle Mantra VR Meridian Waves",
   "Mettle Mantra VR Mirrors",
   "Mettle Mantra VR Mobius Raw",
   "Mettle Mantra VR Mobius Rotate",
   "Mettle Mantra VR Mobius Transform",
   "Mettle Mantra VR Primitivz",
   "Mettle Mantra VR Repeater",
   "Mettle Mantra VR Spherify",
   "Mettle Mantra VR Stretcher",
   "Mettle Mantra VR Turbulence",
   "Mettle Mantra VR Twirl",
   "Mettle Flux",
   "Mettle FreeForm",
   "Mettle FreeForm Pro",
   "Mettle ShapeShifter"
  };

        public static List<string> newBlue = new List<string> {

   "NewBlue Active Camera",
   "NewBlue Alpha Processor",
   "NewBlue Auto Pan",
   "NewBlue Background Generator",
   "NewBlue Chroma Key Pro",
   "NewBlue Cut Away",
   "NewBlue Drop Shadow",
   "NewBlue Flying PiP",
   "NewBlue Garbage Matte",
   "NewBlue Gradient Fill Pro",
   "NewBlue Image Mapper",
   "NewBlue Luma Key",
   "NewBlue Outline",
   "NewBlue Picture Grid",
   "NewBlue Picture-In-Picture",
   "NewBlue Picture-In-Shape",
   "NewBlue Reflection",
   "NewBlue Split Screen",
   "NewBlue Tile",
   "NewBlue Time Clock",
   "NewBlue Viewfinder",
   "NewBlue Aspect Ratio",
   "NewBlue Auto Contrast",
   "NewBlue Color Fixer Pro",
   "NewBlue Crop Borders",
   "NewBlue Detail by Chroma",
   "NewBlue Detail by Luma",
   "NewBlue Detail Enhancer",
   "NewBlue Edge Smoother",
   "NewBlue Flash Remover Pro",
   "NewBlue Gamma Corrector",
   "NewBlue Legal Level",
   "NewBlue Lens Correction",
   "NewBlue Noise Reducer",
   "NewBlue Pixelator",
   "NewBlue Progressive Stretch",
   "NewBlue Proportion Helper",
   "NewBlue Quick Pixelator",
   "NewBlue Region Scope",
   "NewBlue Selective Focus",
   "NewBlue Selective Touch Up",
   "NewBlue Sharpen",
   "NewBlue Skin Touch Up",
   "NewBlue Stabilizer",
   "NewBlue Video Tuneup",
   "NewBlue Video Tuneup Plus",
   "NewBlue Bleach Bypass",
   "NewBlue Color Replace",
   "NewBlue ColorFast",
   "NewBlue ColorFast 2",
   "NewBlue Colorize",
   "NewBlue Day for Night",
   "NewBlue Diffusion",
   "NewBlue Dream Glow",
   "NewBlue Duochrome",
   "NewBlue Film Camera",
   "NewBlue Film Color",
   "NewBlue Film Color 2",
   "NewBlue Film Grain",
   "NewBlue Fish Eye",
   "NewBlue Frame Rate",
   "NewBlue Gradient Tint",
   "NewBlue Light Leak",
   "NewBlue Old TV",
   "NewBlue Saturation EQ",
   "NewBlue Saturation Modifier",
   "NewBlue Selective Color",
   "NewBlue Selective Hue",
   "NewBlue Selective Tint",
   "NewBlue Soft Focus",
   "NewBlue Spotlight",
   "NewBlue Tilt Shift",
   "NewBlue Tint",
   "NewBlue Vignette",
   "NewBlue Air Brush",
   "NewBlue Cartoonr Plus",
   "NewBlue Charcoal",
   "NewBlue Colored Pencil",
   "NewBlue Earthquake",
   "NewBlue Flicker",
   "NewBlue Glow Pro",
   "NewBlue Halovision Plus",
   "NewBlue Hand Drawn",
   "NewBlue Impressionist",
   "NewBlue Metallic",
   "NewBlue Mosaic",
   "NewBlue Mural",
   "NewBlue Neon Lights",
   "NewBlue Oil",
   "NewBlue Paper Collage",
   "NewBlue Pencil Rubbing",
   "NewBlue RGB Shift",
   "NewBlue Rolling Waves",
   "NewBlue Shear Energy",
   "NewBlue Warp",
   "NewBlue Water Color",
   "NewBlue Wiggle",
   "NewBlue Zoom Blur",
   "NewBlue Tilter Pro 5",
  };

        public static List<string> rowbyte = new List<string> {
   "Rowbyte Aura",
   "Rowbyte Bad TV",
   "Rowbyte Data Glitch",
   "Rowbyte Dot Pixels",
   "Rowbyte Fast Bokeh",
   "Rowbyte Plexus",
   "Rowbyte Seperate RGB",
   "Rowbyte TVPixel"
    };

        public static List<string> other = new List<string> {
    "Cinema Spice Glitchify",
    "Cinema Spice Polytrace",
    "Digital Anarchy Flicker Free",
    "Frischluft FL Amiga Rulez",
    "Frischluft FL Box Blur",
    "Frischluft FL Depth Of Field",
    "Frischluft FL Glas Sphere",
    "Frischluft FL Glow",
    "Frischluft FL Highlight",
    "Frischluft FL Mosaic Plane",
    "Frischluft FL Out Of Focus",
    "Frischluft FL Radial Blur",
    "Frischluft FL Volumetrics",
    "Gabgren 2000 AE Pixel Sorter 2",
    "jAe Tools Real Glow",
    "minning.de Normality",
    "omino omino colorizer",
    "omino omino diffusion",
    "omino omino halftone++",
    "omino omino kaledioscope",
    "omino omino snake",
    "omino omino sphere map",
    "omino omino squares",
    "omino omino test",
    "Plugin Everything Deep Glow",
    "Superluminal Stardust",
    "Taronites ZbornToy",
    "Wunk Effects PixDither"
  };
    }
}
