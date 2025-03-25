export const addResizeObserver = (elementSelector, dotNetObj) => {
    const element = document.querySelector(elementSelector);
    if (!element || !dotNetObj) return;

    const observer = new ResizeObserver((entries) => {
        if (!dotNetObj) return;
        dotNetObj?.invokeMethodAsync('OnResized', entries[0]?.contentRect)
    });
    observer?.observe(element);

    return () => {        
        observer?.unobserve(element);
        observer?.disconnect();
    };
};