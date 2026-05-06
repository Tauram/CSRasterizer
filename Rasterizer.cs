public class Rasterizer
{
    public int ResX = 640;
    public int ResY = 360;
    Vector3[] ColorData;

    public Vector3[] Rasterize(Vector3 CameraPos, Vector3 CameraForward, Vector3[] Vertices)
    {
        ColorData = new Vector3[ResX * ResY];

        // Draw vertices
        for(int i = 0; i < Vertices.Length; i++){
            int Index = 0;
            if(Index >= 0 && Index < ResX * ResY){
                ColorData[Index] = new Vector3(1f, 1f, 1f);
            }
        }

        return ColorData;
    }

    public class Vector3
    {
        public float X = 0f;
        public float Y = 0f;
        public float Z = 0f;

        public Vector3(float VX, float VY, float VZ){
            X = VX;
            Y = VY;
            Z = VZ;
        }
    }
}