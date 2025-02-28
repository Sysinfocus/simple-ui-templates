using Microsoft.AspNetCore.Components;

namespace SimpleUITemplates.UI.Contributors.RahulHadgal;
public partial class RatingComponent
{
    [Parameter] public EventCallback<int> OnRatingChanged { get; set; }

    [Parameter] public string? Spacing { get; set; } = "0.25rem";

    [Parameter] public string? Icon { get; set; } = "star";

    [Parameter] public string? Size { get; set; } = "24px";

    [Parameter] public string? NormalColor { get; set; } = "var(--primary-fg)";

    [Parameter] public string? RatingColor { get; set; } = "orange";

    [Parameter] public int InitialRating { get; set; }

    private int currentRating, selectedRating;

    protected override void OnParametersSet() => selectedRating = InitialRating;

    private void ClearRating() => currentRating = 0;

    private string? GetColor(int rating) =>
        (selectedRating >= rating || currentRating >= rating)
        ? RatingColor : NormalColor;

    private void SetColor(int rating) => currentRating = rating;

    private async Task HandleRating()
    {
        // If same rating is clicked, it will remove the rating
        if (selectedRating == currentRating)
        {
            selectedRating = currentRating = 0;
            await OnRatingChanged.InvokeAsync(0);
            return;
        }

        selectedRating = currentRating;
        await OnRatingChanged.InvokeAsync(selectedRating);
    }
}