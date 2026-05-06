# CSRasterizer

CSRasterizer is a C# script that generates a raster image (array of coloured pixels) out of 3D mesh data.

It is built to not use any existing math libraries, and instead defines 3D vectors and other mathematical constructs itself.

# Rasterizer.cs

## Rasterizer (class)

**Properties:**

- **ResX** - Width of the rendered image in pixels as int

- **ResY** - Height of the rendered image in pixels as int

### Rasterize (Vector3[])

Returns the image as an array of pixels (RGB colour represented with Vector3) row by row starting at the bottom left

**Declaration:**

Rasterize(Vector3 CameraPos, Vector3 CameraForward, Vector3[] Vertices)

**Parameters:**

- **CameraPos** - XYZ-position of the camera (viewer) as Vector3

- **CameraForward** - Forward direction of the camera (viewer) as Vector3

- **Vertices** - XYZ-positions of the vertices as Vector3[]

### Vector3 (subclass)

**Properties:**

- **X** - X component of the vector as float

- **Y** - Y component of the vector as float

- **Z** - Z component of the vector as float

**Constructors:**

- **Vector3** - declared with Vector3(float X, float Y, float Z)

# Examples Usage

```csharp
Rasterizer.Vector3[] Vertices; // XYZ-positions of rendered vertices

void Main(){
  Rasterizer Instance; // Instantiate Rasterizer class
  Instance.ResX = 640; // Set rendered image width to 640 pixels
  Instance.ResY = 360; // Set rendered image height to 360 pixels

  // Rasterize with camera at (0, 0, 0) and Z+ as the forward direction
  Rasterizer.Vector3[] Rasterization = Instance.Rasterize(new Rasterizer.Vector3(0, 0, 0), new Rasterizer.Vector3(0, 0, 1), Vertices);
}
```
