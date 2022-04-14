<script>
    var ValidaExclusao = function (id, evento) {
        if (confirm("Confirma Exclusão?")) {
            return true;
        }
    else {
        event.preventDefault();
    return false;
        }
    }
</script>