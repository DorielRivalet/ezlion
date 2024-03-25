<script langs="ts">
	import { onMount } from 'svelte';
	import { page } from '$app/stores';

	onMount(() => {
		const script = document.createElement('script');
		script.src = 'https://cdn.jsdelivr.net/npm/@scalar/api-reference';
		script.id = 'api-reference';
		script.dataset.url = `https://${$page.url.hostname}/openapi.json`;
		document.body.appendChild(script);

		// Custom configuration
		const configuration = {
			theme: 'purple'
			// Add more configuration options here
		};

		const apiReference = document.getElementById('api-reference');
		apiReference.dataset.configuration = JSON.stringify(configuration);
	});
</script>

<div id="api-reference-container"></div>
