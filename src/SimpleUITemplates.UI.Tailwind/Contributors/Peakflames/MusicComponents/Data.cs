
namespace SimpleUITemplates.UI.Tailwind.Contributors.Peakflames.MusicComponents;

public record Album(string Name, string Artist, string Cover);


// https://ui.shadcn.com/_next/image?url=https%3A%2F%2Fimages.unsplash.com%2Fphoto-1611348586804-61bf6c080437%3Fw%3D300%26dpr%3D2%26q%3D80&w=640&q=75
// https://ui.shadcn.com/_next/image?url=https%3A%2F%2Fimages.unsplash.com%2Fphoto-1611348586804-61bf6c080437%3Fw%3D300%26dpr%3D2%26q%3D80

public static class DataStore
{
    public const string NextImageBaseUrl = "https://ui.shadcn.com/_next/image?url=";

    public static string EscapedNextImageUri(string imagePath) => $"{NextImageBaseUrl}{Uri.EscapeDataString(imagePath)}&w=640&q=75";

    public static List<Album> ListenNowAlbums = [
        new (
            Name: "React Rendezvous",
            Artist: "Ethan Byte",
            Cover: EscapedNextImageUri("https://images.unsplash.com/photo-1611348586804-61bf6c080437?w=300&dpr=2&q=80")
        ),
        new (
            Name: "Async Awakenings",
            Artist: "Nina Netcode",
            Cover:EscapedNextImageUri("https://images.unsplash.com/photo-1468817814611-b7edf94b5d60?w=300&dpr=2&q=80")
        ),
        new (
            Name: "The Art of Reusability",
            Artist: "Lena Logic",
            Cover: EscapedNextImageUri("https://images.unsplash.com/photo-1528143358888-6d3c7f67bd5d?w=300&dpr=2&q=80")
        ),
        new (
            Name: "Stateful Symphony",
            Artist: "Beth Binary",
            Cover: EscapedNextImageUri("https://images.unsplash.com/photo-1490300472339-79e4adc6be4a?w=300&dpr=2&q=80")
        ),
    ];

    public static List<Album> MadeForYouAlbums = [
        new (
            Name: "Thinking Components",
            Artist: "Lena Logic",
            Cover: EscapedNextImageUri("https://images.unsplash.com/photo-1615247001958-f4bc92fa6a4a?w=300&dpr=2&q=80")
        ),
        new (
            Name: "Functional Fury",
            Artist: "Beth Binary",
            Cover: EscapedNextImageUri("https://images.unsplash.com/photo-1513745405825-efaf9a49315f?w=300&dpr=2&q=80")
        ),
        new (
            Name: "React Rendezvous",
            Artist: "Ethan Byte",
            Cover: EscapedNextImageUri("https://images.unsplash.com/photo-1614113489855-66422ad300a4?w=300&dpr=2&q=80")
        ),
        new (
            Name: "Stateful Symphony",
            Artist: "Beth Binary",
            Cover: EscapedNextImageUri("https://images.unsplash.com/photo-1446185250204-f94591f7d702?w=300&dpr=2&q=80")
        ),
        new (
            Name: "Async Awakenings",
            Artist: "Nina Netcode",
            Cover: EscapedNextImageUri("https://images.unsplash.com/photo-1468817814611-b7edf94b5d60?w=300&dpr=2&q=80")
        ),
        new (
            Name: "The Art of Reusability",
            Artist: "Lena Logic",
            Cover: EscapedNextImageUri("https://images.unsplash.com/photo-1490300472339-79e4adc6be4a?w=300&dpr=2&q=80")
        ),
    ];
}