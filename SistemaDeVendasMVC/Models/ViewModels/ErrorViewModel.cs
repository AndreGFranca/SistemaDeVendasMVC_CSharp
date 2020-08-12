using System;

namespace SistemaDeVendasMVC.Models.ViewModels {
    public class ErrorViewModel {
        public string RequestId { get; set; }

        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}