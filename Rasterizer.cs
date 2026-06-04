public class Rasterizer
{
    public int ResX = 640;
    public int ResY = 360;
    Vector3 CameraPos;
    Vector3 CameraForward;

    public Vector3[] Rasterize(Vector3[] Vertices)
    {
        Vector3[] ColorData = new Vector3[ResX * ResY];

        // Initialize ColorData to all black
        for(int i = 0; i < ResX * ResY; i++){
            ColorData[i] = new Vector3(0f, 0f, 0f);
        }

        // Draw vertices
        for(int i = 0; i < Vertices.Length; i++){
            int Index = (int)System.Math.Round((float)ResY / 2f + Vertices[i].Y) * ResX + (int)System.Math.Round((float)ResX / 2f + Vertices[i].X);
            if(Index >= 0 && Index < ResX * ResY){
                ColorData[Index] = new Vector3(1f, 1f, 1f);
            }
        }

        return ColorData;
    }

    public Rasterizer(int Width, int Height, Vector3 Position, Vector3 Forward)
    {
        ResX = Width;
        ResY = Height;
        CameraPos = Position;
        CameraForward = Forward;
    }

    public class Vector3
    {
        public float X = 0f;
        public float Y = 0f;
        public float Z = 0f;

        public Vector3(float VX = 0f, float VY = 0f, float VZ = 0f){
            X = VX;
            Y = VY;
            Z = VZ;
        }
    }
}