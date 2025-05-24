using Microsoft.AspNetCore.Components;

namespace myapp.Components.Pages.Components;

public partial class Cards() :  ComponentBase
{
  [Parameter]
  public RenderFragment? ChildContent { get; set; }
  [Parameter]
  public string? Title { get; set; }
  [Parameter]
  public string? Conteudo { get; set; }
  [Parameter]
  public string? txtButtom { get; set; }
  [Parameter]
  public EventCallback EventClick { get; set; }

  public void OnClick()
  {

    Title = "trocou o texto";
  }
}