<script lang="ts">
	import { onMount } from 'svelte';
	import { page } from '$app/stores';
	import './catppuccin.css';

	onMount(() => {
		const script = document.createElement('script');
		script.src = 'https://cdn.jsdelivr.net/npm/@scalar/api-reference';
		script.id = 'api-reference';
		script.dataset.url = `https://${$page.url.hostname}/openapi.json`;
		document.body.appendChild(script);

		const apiReference = document.getElementById('api-reference');
	});
</script>

<header>test</header>
<div id="api-reference-container"></div>
