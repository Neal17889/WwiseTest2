using UnityEditor;
using UnityEngine;

namespace PostProcessor
{
    public class UTexturePreprocessor : AssetPostprocessor
    {
        public static bool IsHD = false;

        void OnPreprocessTexture()
        {
            TextureImporter textureImporter = (TextureImporter)assetImporter;
            textureImporter.isReadable = false;

            if (assetPath.StartsWith("Assets/UI"))
            {
                textureImporter.mipmapEnabled = false; // �Զ����� mipmap
                textureImporter.textureType = TextureImporterType.Sprite;
            }
            else if (assetPath.StartsWith("Assets/Units"))
            {
                // ʹ�� textureCompression ��� textureFormat
                textureImporter.textureCompression = TextureImporterCompression.Compressed;
            }
            else if (assetPath.StartsWith("Assets/FX/Textures"))
            {
                // ʹ�� PlatformTextureSettings ������ƽ̨�ض��ĸ�ʽ
                if (textureImporter.textureCompression == TextureImporterCompression.Uncompressed)
                {
                    TextureImporterPlatformSettings platformSettings = new TextureImporterPlatformSettings();
                    platformSettings.format = TextureImporterFormat.RGBA16; // ʾ��������Ϊ���ʵĸ�ʽ
                    textureImporter.SetPlatformTextureSettings(platformSettings);
                }
                else
                {
                    textureImporter.textureCompression = TextureImporterCompression.Compressed;
                }
            }
        }
    }
}
